﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ReportTrackingConfiguration : IEntityTypeConfiguration<ReportTracking>
    {
        public void Configure(EntityTypeBuilder<ReportTracking> builder)
        {
            builder.HasKey(e => e.ReportTrackingId);

            builder.Property(e => e.ReportTrackingId)
                .HasColumnName("ReportTrackingId");

            builder.Property(e => e.EmployeeId)
                .IsRequired();

            builder.Property(e => e.TrackingDate)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne(rt => rt.ReportNav)
                .WithMany()
                .HasForeignKey(rt => rt.ReportId);

            builder.HasOne(rt => rt.ReportOperationNav)
                .WithMany()
                .HasForeignKey(rt => rt.ReportOperationId);
        }
    }
}
