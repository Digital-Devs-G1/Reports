﻿using Application.Interfaces.IRepositories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GenericRepositoryCommand<T> : IGenericRepositoryCommand<T> where T : BaseEntity
    {
        private readonly ReportsDbContext context;
        private readonly DbSet<T> entities;

        public GenericRepositoryCommand(ReportsDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            entities.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            entities.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}
