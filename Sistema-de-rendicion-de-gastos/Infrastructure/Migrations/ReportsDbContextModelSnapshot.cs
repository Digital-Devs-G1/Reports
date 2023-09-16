﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ReportsDbContext))]
    partial class ReportsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Domain.Entities.DeptoTemplate", b =>
                {
                    b.Property<int>("TemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TemplateId"));

                    b.Property<int>("DeptoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("TemplateId");

                    b.ToTable("DeptoTemplate");

                    b.HasData(
                        new
                        {
                            TemplateId = 1,
                            DeptoId = 1,
                            Name = "Auto Propio"
                        },
                        new
                        {
                            TemplateId = 2,
                            DeptoId = 1,
                            Name = "Servicio Viaje"
                        },
                        new
                        {
                            TemplateId = 3,
                            DeptoId = 1,
                            Name = "Viaticos"
                        },
                        new
                        {
                            TemplateId = 4,
                            DeptoId = 2,
                            Name = "Material.Const."
                        },
                        new
                        {
                            TemplateId = 5,
                            DeptoId = 2,
                            Name = "Viaticos"
                        });
                });

            modelBuilder.Entity("Domain.Entities.FieldTemplate", b =>
                {
                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("DataTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.HasKey("TemplateId", "Label");

                    b.HasIndex("DataTypeId");

                    b.ToTable("FieldTemplate");

                    b.HasData(
                        new
                        {
                            TemplateId = 1,
                            Label = "Fecha",
                            DataTypeId = 3,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 1,
                            Label = "Destino",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 1,
                            Label = "Km",
                            DataTypeId = 5,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 1,
                            Label = "Peajes",
                            DataTypeId = 4,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 1,
                            Label = "Monto Peajes",
                            DataTypeId = 5,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 2,
                            Label = "Fecha",
                            DataTypeId = 3,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 2,
                            Label = "Destino",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 2,
                            Label = "Nombre Servicio",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 2,
                            Label = "Comprobante",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 3,
                            Label = "Fecha",
                            DataTypeId = 3,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 3,
                            Label = "Viatico",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 3,
                            Label = "Motivo",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 3,
                            Label = "Comprobante",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 4,
                            Label = "Fecha",
                            DataTypeId = 3,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 4,
                            Label = "Proveedor",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 4,
                            Label = "Contacto",
                            DataTypeId = 1,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 4,
                            Label = "Nombre Material",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 4,
                            Label = "Peso [Kg]",
                            DataTypeId = 5,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 4,
                            Label = "Ancho [mm]",
                            DataTypeId = 5,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 4,
                            Label = "Alto [mm]",
                            DataTypeId = 5,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 5,
                            Label = "Fecha",
                            DataTypeId = 3,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 5,
                            Label = "Viatico",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 5,
                            Label = "Motivo",
                            DataTypeId = 2,
                            Enabled = true
                        },
                        new
                        {
                            TemplateId = 5,
                            Label = "Comprobante",
                            DataTypeId = 2,
                            Enabled = true
                        });
                });

            modelBuilder.Entity("Domain.Entities.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReportId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 7500.0,
                            Description = "Bolsa de cemento",
                            EmployeeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 15000.0,
                            Description = "Placa Mdf",
                            EmployeeId = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.ReportOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReportOperationId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ReportOperationName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("ReportOperations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ReportOperationName = "Pendiente"
                        },
                        new
                        {
                            Id = 2,
                            ReportOperationName = "Aceptado"
                        },
                        new
                        {
                            Id = 3,
                            ReportOperationName = "Rechazado"
                        });
                });

            modelBuilder.Entity("Domain.Entities.ReportTracking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ReportTrackingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateTracking")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.Property<int>("ReportOperationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReportId");

                    b.HasIndex("ReportOperationId");

                    b.ToTable("ReportTrackings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTracking = new DateTime(2023, 9, 16, 18, 30, 23, 343, DateTimeKind.Local).AddTicks(7787),
                            EmployeeId = 1,
                            ReportId = 1,
                            ReportOperationId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateTracking = new DateTime(2023, 9, 16, 18, 30, 23, 343, DateTimeKind.Local).AddTicks(7798),
                            EmployeeId = 1,
                            ReportId = 2,
                            ReportOperationId = 1
                        });
                });

            modelBuilder.Entity("Domain.Entities.VariableField", b =>
                {
                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("DataTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ReportId", "Label");

                    b.HasIndex("DataTypeId");

                    b.ToTable("VariableFields");

                    b.HasData(
                        new
                        {
                            ReportId = 1,
                            Label = "Proveedor",
                            DataTypeId = 2,
                            Value = "Constructura X SRL"
                        },
                        new
                        {
                            ReportId = 1,
                            Label = "Tel. Proveedor",
                            DataTypeId = 1,
                            Value = "42561873"
                        },
                        new
                        {
                            ReportId = 2,
                            Label = "Ancho[mm]",
                            DataTypeId = 1,
                            Value = "270"
                        },
                        new
                        {
                            ReportId = 2,
                            Label = "Alto",
                            DataTypeId = 1,
                            Value = "180"
                        },
                        new
                        {
                            ReportId = 2,
                            Label = "Peso[kg]",
                            DataTypeId = 5,
                            Value = "58.8"
                        });
                });

            modelBuilder.Entity("Domain.Entities.FieldTemplate", b =>
                {
                    b.HasOne("Domain.Entities.DataType", "DataTypeNav")
                        .WithMany("FieldTemplateNav")
                        .HasForeignKey("DataTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.DeptoTemplate", "DeptoTemplateNav")
                        .WithMany("FieldTemplateCollec")
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataTypeNav");

                    b.Navigation("DeptoTemplateNav");
                });

            modelBuilder.Entity("Domain.Entities.ReportTracking", b =>
                {
                    b.HasOne("Domain.Entities.Report", "Report")
                        .WithMany("Trackings")
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ReportOperation", "ReportOperation")
                        .WithMany("Trackings")
                        .HasForeignKey("ReportOperationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Report");

                    b.Navigation("ReportOperation");
                });

            modelBuilder.Entity("Domain.Entities.VariableField", b =>
                {
                    b.HasOne("Domain.Entities.DataType", "DataTypeNav")
                        .WithMany("Fields")
                        .HasForeignKey("DataTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Report", "ReportNav")
                        .WithMany("Fields")
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DataTypeNav");

                    b.Navigation("ReportNav");
                });

            modelBuilder.Entity("Domain.Entities.DataType", b =>
                {
                    b.Navigation("FieldTemplateNav");

                    b.Navigation("Fields");
                });

            modelBuilder.Entity("Domain.Entities.DeptoTemplate", b =>
                {
                    b.Navigation("FieldTemplateCollec");
                });

            modelBuilder.Entity("Domain.Entities.Report", b =>
                {
                    b.Navigation("Fields");

                    b.Navigation("Trackings");
                });

            modelBuilder.Entity("Domain.Entities.ReportOperation", b =>
                {
                    b.Navigation("Trackings");
                });
#pragma warning restore 612, 618
        }
    }
}
