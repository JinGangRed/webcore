using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string CreateBy { get; set; }

        public DateTime CreateTime { get; set; }

        public string UpdateBy { get; set; }

        public DateTime UpdateTime { get; set; }

        public EntityStatus Status { get; set; }

    }
}
