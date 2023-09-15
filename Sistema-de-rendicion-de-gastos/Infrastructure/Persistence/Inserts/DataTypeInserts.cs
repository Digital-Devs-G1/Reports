﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Inserts
{
    public class DataTypeInserts : IEntityTypeConfiguration<DataType>
    {
        public void Configure(EntityTypeBuilder<DataType> builder)
        {
            builder.HasData(
                new DataType()
                {
                    DataTypeId = 1,
                    Name = "Entero"
                },
                new DataType()
                {
                    DataTypeId = 2,
                    Name = "String"
                },
                new DataType()
                {
                    DataTypeId = 3,
                    Name = "Date"
                },
                new DataType()
                {
                    DataTypeId = 4,
                    Name = "Bool"
                }, 
                new DataType()
                {
                    DataTypeId = 5,
                    Name = "Decimal"
                }
            );
        }
    }
}