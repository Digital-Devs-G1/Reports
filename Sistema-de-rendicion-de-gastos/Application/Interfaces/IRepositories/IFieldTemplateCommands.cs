﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.IRepositories
{
    public interface IFieldTemplateCommands
    {
        public Task DeleteRange(FieldTemplate entity);
    }
}
