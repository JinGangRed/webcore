﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Common
{
    public interface ISoftDeleteEntity
    {
        bool IsDelete { get; set; }
    }
}
