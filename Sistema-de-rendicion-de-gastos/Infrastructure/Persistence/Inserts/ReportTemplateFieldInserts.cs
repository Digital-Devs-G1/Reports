﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static Application.Enums.DataTypeEnum;

namespace Infrastructure.Persistence.Inserts
{
    internal class Field
    {
        public string Name { get; set; }
        public int TypeId { get; set; }

        public Field(string name, int typeId)
        {
            TypeId = typeId;
            Name = name;
        }
    }

    public class ReportTemplateFieldInserts : IEntityTypeConfiguration<ReportTemplateField>
    {
        private int _autoincrement = 1;
        public void Configure(EntityTypeBuilder<ReportTemplateField> builder)
        {
            DeptoOneTemplates(builder);
            DeptoTwoTemplates(builder);
            DeptoThreeTemplates(builder);
        }

        // Al departamento 3 se le asignaron 2 templates en DeptoTemplateInserts
        private void DeptoThreeTemplates(EntityTypeBuilder<ReportTemplateField> builder)
        {
            AddTemplate(builder, new List<Field>()
            {
                new Field("Proveedor", (int)Str),
                new Field("Tel. Proveedor", (int)Int)
            });
            AddTemplate(builder, new List<Field>()
            {
                new Field("Ancho [mm]", (int)Int),
                new Field("Alto [mm]", (int)Int),
                new Field("Peso [Kg]", (int)Dec)
            });
        }

        // Al departamento 2 se le asignaron 3 templates en DeptoTemplateInserts
        private void DeptoOneTemplates(EntityTypeBuilder<ReportTemplateField> builder)
        {
            AddTemplate(builder, new List<Field>()
            {
                new Field("Destino", (int)Str),
                new Field("Km", (int)Dec),
                new Field("HuboPeajes", (int)Bool),
                new Field("Monto Peajes", (int)Dec),
            });
            AddTemplate(builder, new List<Field>()
            {
                new Field("Destino", (int)Str),
                new Field("Nombre Servicio", (int)Str),
                new Field("Comprobante", (int)Str)
            });
            AddTemplate(builder, new List<Field>()
            {
                new Field("Viatico", (int)Str),
                new Field("Motivo", (int)Str),
                new Field("Comprobante", (int)Str)
            });
        }

        // Al departamento 2 se le asignaron 2 templates en DeptoTemplateInserts
        private void DeptoTwoTemplates(EntityTypeBuilder<ReportTemplateField> builder)
        {
            AddTemplate(builder, new List<Field>()
            {
                new Field("Proveedor", (int)Str),
                new Field("Contacto", (int)Int),
                new Field("Nombre Material", (int)Str),
                new Field("Peso [Kg]", (int)Dec),
                new Field("Ancho [mm]", (int)Int),
                new Field("Alto [mm]", (int)Int),
            });
            AddTemplate(builder, new List<Field>()
            {
                new Field("Viatico", (int)Str),
                new Field("Motivo", (int)Str),
                new Field("Comprobante", (int)Str)
            });
        }

        private void AddTemplate(
            EntityTypeBuilder<ReportTemplateField> builder,
            IList<Field> fieldsValues)
        {
            int i = 0;
            List<ReportTemplateField> templateFields = new List<ReportTemplateField>();
            foreach (var field in fieldsValues)
                templateFields.Add(new ReportTemplateField()
                {
                    ReportTemplateId = _autoincrement,
                    Name = field.Name,
                    DataTypeId = field.TypeId,
                    Enabled = true,
                }
                );
            _autoincrement++;
            builder.HasData(templateFields);
        }
    }
}