﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Response.Response.EntityProxy
{
    public class FieldTemplateResponse
    {
        private readonly FieldTemplate _fieldTemplate;

        public FieldTemplateResponse(FieldTemplate fieldTemplate)
        {
            _fieldTemplate = fieldTemplate;
        }

        public int FieldTemplateId { get { return _fieldTemplate.DepartmentTemplateId; } set { _fieldTemplate.DepartmentTemplateId = value; } }
        public string Name { get { return _fieldTemplate.Name; } set { _fieldTemplate.Name = value; } }
        public int DataTypeId { get { return _fieldTemplate.DataTypeId; } set { _fieldTemplate.DataTypeId = value; } }
    }
}
