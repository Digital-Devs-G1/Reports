﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepositories
{
    public interface IFieldTemplateQuerys
    {
        public Task<IList<FieldTemplate>> GetTemplatesById(int tempId);
    }
}
