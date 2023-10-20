﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ReportsDbContext))]
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
    [Migration("20230921022750_Init")]
========
    [Migration("20231020025704_Init")]
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.DataType", b =>
                {
                    b.Property<int>("DataTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DataTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("DataTypeId");

                    b.ToTable("DataType");

                    b.HasData(
                        new
                        {
                            DataTypeId = 1,
                            Name = "Entero"
                        },
                        new
                        {
                            DataTypeId = 2,
                            Name = "String"
                        },
                        new
                        {
                            DataTypeId = 3,
                            Name = "Date"
                        },
                        new
                        {
                            DataTypeId = 4,
                            Name = "Bool"
                        },
                        new
                        {
                            DataTypeId = 5,
                            Name = "Decimal"
                        });
                });

            modelBuilder.Entity("Domain.Entities.DepartmentTemplate", b =>
                {
                    b.Property<int>("DepartmentTemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentTemplateId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentTemplateName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("DepartmentTemplateId");

                    b.ToTable("DepartmentTemplates");

                    b.HasData(
                        new
                        {
                            DepartmentTemplateId = 1,
                            DepartmentId = 1,
                            DepartmentTemplateName = "Auto Propio"
                        },
                        new
                        {
                            DepartmentTemplateId = 2,
                            DepartmentId = 1,
                            DepartmentTemplateName = "Servicio Viaje"
                        },
                        new
                        {
                            DepartmentTemplateId = 3,
                            DepartmentId = 1,
                            DepartmentTemplateName = "Viaticos"
                        },
                        new
                        {
                            DepartmentTemplateId = 4,
                            DepartmentId = 2,
                            DepartmentTemplateName = "Gastos varios"
                        },
                        new
                        {
                            DepartmentTemplateId = 5,
                            DepartmentId = 2,
                            DepartmentTemplateName = "Materia prima"
                        },
                        new
                        {
                            DepartmentTemplateId = 6,
                            DepartmentId = 3,
                            DepartmentTemplateName = "Materiales de Construccion"
                        },
                        new
                        {
                            DepartmentTemplateId = 7,
                            DepartmentId = 3,
                            DepartmentTemplateName = "Placas de Carpinteria"
                        });
                });

            modelBuilder.Entity("Domain.Entities.FieldTemplate", b =>
                {
                    b.Property<int>("DepartmentTemplateId")
                        .HasColumnType("int");

                    b.Property<int>("OrdinalNumber")
                        .HasColumnType("int");

                    b.Property<int>("DataTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("DepartmentTemplateId", "OrdinalNumber");

                    b.HasIndex("DataTypeId");

                    b.ToTable("FieldTemplates");

                    b.HasData(
                        new
                        {
                            DepartmentTemplateId = 1,
                            OrdinalNumber = 1,
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Destino"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 1,
                            OrdinalNumber = 2,
========
                            FieldTemplateId = 1,
                            FieldNameId = "Km",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 5,
                            Enabled = true,
                            Name = "Km"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 1,
                            OrdinalNumber = 3,
========
                            FieldTemplateId = 1,
                            FieldNameId = "HuboPeajes",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 4,
                            Enabled = true,
                            Name = "HuboPeajes"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 1,
                            OrdinalNumber = 4,
========
                            FieldTemplateId = 1,
                            FieldNameId = "Monto Peajes",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 5,
                            Enabled = true,
                            Name = "Monto Peajes"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 2,
                            OrdinalNumber = 1,
========
                            FieldTemplateId = 2,
                            FieldNameId = "Destino",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Destino"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 2,
                            OrdinalNumber = 2,
========
                            FieldTemplateId = 2,
                            FieldNameId = "Nombre Servicio",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Nombre Servicio"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 2,
                            OrdinalNumber = 3,
========
                            FieldTemplateId = 2,
                            FieldNameId = "Comprobante",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Comprobante"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 3,
                            OrdinalNumber = 1,
========
                            FieldTemplateId = 3,
                            FieldNameId = "Viatico",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Viatico"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 3,
                            OrdinalNumber = 2,
========
                            FieldTemplateId = 3,
                            FieldNameId = "Motivo",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Motivo"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 3,
                            OrdinalNumber = 3,
========
                            FieldTemplateId = 3,
                            FieldNameId = "Comprobante",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Comprobante"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 4,
                            OrdinalNumber = 1,
========
                            FieldTemplateId = 4,
                            FieldNameId = "Proveedor",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Proveedor"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 4,
                            OrdinalNumber = 2,
========
                            FieldTemplateId = 4,
                            FieldNameId = "Contacto",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 1,
                            Enabled = true,
                            Name = "Contacto"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 4,
                            OrdinalNumber = 3,
========
                            FieldTemplateId = 4,
                            FieldNameId = "Nombre Material",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Nombre Material"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 4,
                            OrdinalNumber = 4,
========
                            FieldTemplateId = 4,
                            FieldNameId = "Peso [Kg]",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 5,
                            Enabled = true,
                            Name = "Peso [Kg]"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 4,
                            OrdinalNumber = 5,
========
                            FieldTemplateId = 4,
                            FieldNameId = "Ancho [mm]",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 1,
                            Enabled = true,
                            Name = "Ancho [mm]"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 4,
                            OrdinalNumber = 6,
========
                            FieldTemplateId = 4,
                            FieldNameId = "Alto [mm]",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 1,
                            Enabled = true,
                            Name = "Alto [mm]"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 5,
                            OrdinalNumber = 1,
========
                            FieldTemplateId = 5,
                            FieldNameId = "Viatico",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Viatico"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 5,
                            OrdinalNumber = 2,
========
                            FieldTemplateId = 5,
                            FieldNameId = "Motivo",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Motivo"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 5,
                            OrdinalNumber = 3,
========
                            FieldTemplateId = 5,
                            FieldNameId = "Comprobante",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Comprobante"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 6,
                            OrdinalNumber = 1,
========
                            FieldTemplateId = 6,
                            FieldNameId = "Proveedor",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 2,
                            Enabled = true,
                            Name = "Proveedor"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 6,
                            OrdinalNumber = 2,
========
                            FieldTemplateId = 6,
                            FieldNameId = "Tel. Proveedor",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 1,
                            Enabled = true,
                            Name = "Tel. Proveedor"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 7,
                            OrdinalNumber = 1,
========
                            FieldTemplateId = 7,
                            FieldNameId = "Ancho [mm]",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 1,
                            Enabled = true,
                            Name = "Ancho [mm]"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 7,
                            OrdinalNumber = 2,
========
                            FieldTemplateId = 7,
                            FieldNameId = "Alto [mm]",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 1,
                            Enabled = true,
                            Name = "Alto [mm]"
                        },
                        new
                        {
<<<<<<<< HEAD:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20230921022750_Init.Designer.cs
                            DepartmentTemplateId = 7,
                            OrdinalNumber = 3,
========
                            FieldTemplateId = 7,
                            FieldNameId = "Peso [Kg]",
>>>>>>>> emi_feature3:Sistema-de-rendicion-de-gastos/Infrastructure/Migrations/20231020025704_Init.Designer.cs
                            DataTypeId = 5,
                            Enabled = true,
                            Name = "Peso [Kg]"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Report", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReportId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportId"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("ReportId");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            ReportId = 1,
                            Amount = 7500.0,
                            Description = "Bolsa de cemento",
                            EmployeeId = 1
                        },
                        new
                        {
                            ReportId = 2,
                            Amount = 15000.0,
                            Description = "Placa Mdf",
                            EmployeeId = 2
                        },
                        new
                        {
                            ReportId = 3,
                            Amount = 3500.0,
                            Description = "Bola de cal",
                            EmployeeId = 2
                        });
                });

            modelBuilder.Entity("Domain.Entities.ReportOperation", b =>
                {
                    b.Property<int>("ReportOperationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReportOperationId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportOperationId"));

                    b.Property<string>("ReportOperationName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ReportOperationId");

                    b.ToTable("ReportOperations");

                    b.HasData(
                        new
                        {
                            ReportOperationId = 1,
                            ReportOperationName = "Creacion"
                        },
                        new
                        {
                            ReportOperationId = 2,
                            ReportOperationName = "Revision"
                        },
                        new
                        {
                            ReportOperationId = 3,
                            ReportOperationName = "Aprobacion"
                        },
                        new
                        {
                            ReportOperationId = 4,
                            ReportOperationName = "Rechazo"
                        });
                });

            modelBuilder.Entity("Domain.Entities.ReportTracking", b =>
                {
                    b.Property<int>("ReportTrackingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReportTrackingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportTrackingId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.Property<int>("ReportOperationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TrackingDate")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.HasKey("ReportTrackingId");

                    b.HasIndex("ReportId");

                    b.HasIndex("ReportOperationId");

                    b.ToTable("ReportTrackings");

                    b.HasData(
                        new
                        {
                            ReportTrackingId = 1,
                            EmployeeId = 1,
                            ReportId = 1,
                            ReportOperationId = 1,
                            TrackingDate = new DateTime(2023, 9, 5, 14, 30, 20, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReportTrackingId = 2,
                            EmployeeId = 2,
                            ReportId = 2,
                            ReportOperationId = 1,
                            TrackingDate = new DateTime(2023, 9, 7, 9, 20, 9, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReportTrackingId = 3,
                            EmployeeId = 3,
                            ReportId = 2,
                            ReportOperationId = 2,
                            TrackingDate = new DateTime(2023, 9, 15, 16, 15, 43, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReportTrackingId = 4,
                            EmployeeId = 2,
                            ReportId = 3,
                            ReportOperationId = 1,
                            TrackingDate = new DateTime(2023, 9, 17, 18, 33, 1, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Domain.Entities.VariableField", b =>
                {
                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.Property<int>("OrdinalNumberId")
                        .HasColumnType("int");

                    b.Property<int>("DataTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ReportId", "OrdinalNumberId");

                    b.HasIndex("DataTypeId");

                    b.ToTable("VariableFields");

                    b.HasData(
                        new
                        {
                            ReportId = 1,
                            OrdinalNumberId = 1,
                            DataTypeId = 2,
                            Name = "Proveedor",
                            Value = "Constructura X SRL"
                        },
                        new
                        {
                            ReportId = 1,
                            OrdinalNumberId = 2,
                            DataTypeId = 1,
                            Name = "Tel. Proveedor",
                            Value = "42561873"
                        },
                        new
                        {
                            ReportId = 2,
                            OrdinalNumberId = 1,
                            DataTypeId = 1,
                            Name = "Ancho [mm]",
                            Value = "270"
                        },
                        new
                        {
                            ReportId = 2,
                            OrdinalNumberId = 2,
                            DataTypeId = 1,
                            Name = "Alto [mm]",
                            Value = "180"
                        },
                        new
                        {
                            ReportId = 2,
                            OrdinalNumberId = 3,
                            DataTypeId = 5,
                            Name = "Peso [kg]",
                            Value = "58.8"
                        },
                        new
                        {
                            ReportId = 3,
                            OrdinalNumberId = 1,
                            DataTypeId = 2,
                            Name = "Proveedor",
                            Value = "Constructura X SRL"
                        },
                        new
                        {
                            ReportId = 3,
                            OrdinalNumberId = 2,
                            DataTypeId = 1,
                            Name = "Tel. Proveedor",
                            Value = "42561873"
                        });
                });

            modelBuilder.Entity("Domain.Entities.FieldTemplate", b =>
                {
                    b.HasOne("Domain.Entities.DataType", "DataTypeNav")
                        .WithMany()
                        .HasForeignKey("DataTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataTypeNav");
                });

            modelBuilder.Entity("Domain.Entities.ReportTracking", b =>
                {
                    b.HasOne("Domain.Entities.Report", "ReportNav")
                        .WithMany()
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ReportOperation", "ReportOperationNav")
                        .WithMany()
                        .HasForeignKey("ReportOperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReportNav");

                    b.Navigation("ReportOperationNav");
                });

            modelBuilder.Entity("Domain.Entities.VariableField", b =>
                {
                    b.HasOne("Domain.Entities.DataType", "DataTypeNav")
                        .WithMany()
                        .HasForeignKey("DataTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Report", "ReportNav")
                        .WithMany()
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataTypeNav");

                    b.Navigation("ReportNav");
                });
#pragma warning restore 612, 618
        }
    }
}
