﻿using Application.DTO.Response.ReportOperationNS;
using Application.Interfaces.IRepositories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Query
{
    public class ReportTrackingQuery : GenericRepositoryCommand<ReportTracking>, IReportTrackingQuery
    {
        private ReportsDbContext _dbContext;

        public ReportTrackingQuery(ReportsDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ReportTracking>> GetByReportId(int reportId)
        {
            return await _dbContext
                .Set<ReportTracking>()
                .Where(e => e.ReportId == reportId)
                .ToListAsync();
        }

        public async Task<ReportTracking> GetLastTrackingByReportIdAsync(int reportId)
        {
            var trackings = await _dbContext.Set<ReportTracking>()
                .Where(e => e.ReportId == reportId)
                .ToListAsync();
            return trackings.OrderByDescending(e => e.TrackingDate).FirstOrDefault();
        }

        /// <summary>
        /// Retorna todos los reportes con los que interactuo un empleado, ya sea para
        /// crearlos, aprobarlos, etc. Para cada reporte se especifica como y cuando fue
        /// dicha interaccion.
        /// </summary>
        /// <param name="employeeId">ID del empleado que interactuo con los reportes.</param>
        /// <returns>Lista de Historiales de operacion que el empleado realizo en cada uno de los 
        /// reportes en cuestion.</returns>
        public async Task<IList<ReportInteraction>> GetEmployeeReportInteractions(int employeeId)
        {
            var result = await _dbContext
                .Set<ReportTracking>()
                .Include(reportTracking => reportTracking.ReportOperationNav)
                .Where(reportTracking => reportTracking.EmployeeId == employeeId)
                .Select(rt => new ReportInteraction
                {
                    ReportId = rt.ReportId,
                    TrackingDate = rt.TrackingDate,
                    ReportOperationName = rt.ReportOperationNav.ReportOperationName
                })
                .ToListAsync();
            return result;
        }

        /// <summary>
        /// Retorna la lista de operaciones realizadas (por multiples empleados) sobre cada 
        /// uno de los reportes creador por un empleado en partituclar.
        /// </summary>
        /// <param name="employeeId">ID del empleado que los creo.</param>
        /// <returns>Lista de historiales de operacion de reportes creados por un empleado
        /// en particular.</returns>
        public async Task<IList<ReportOperationHistory>> GetReportHistoryByCreator(int employeeId)
        {
            var resultado = await _dbContext
                .Set<ReportTracking>()
                .Include(reportTracking => reportTracking.ReportOperationNav)
                .Include(reportTracking => reportTracking.ReportNav)
                .Where(rt => rt.ReportNav.EmployeeId == employeeId)
                .GroupBy(tracking => tracking.ReportId)
                .Select(group => new ReportOperationHistory()
                {
                    ReportId = group.Key,
                    Operations = group.Select(tracking => new ReportOperationHistoryItem
                    {
                        TrackingDate = tracking.TrackingDate,
                        EmployeeId = tracking.EmployeeId,
                        ReportOperationName = tracking.ReportOperationNav.ReportOperationName
                    }).ToList()
                })
                .ToListAsync();
            return resultado;
        }
    }
}
