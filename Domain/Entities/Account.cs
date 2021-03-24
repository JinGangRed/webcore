using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Account : BaseEntity, ISoftDeleteEntity
    {
        public string AccountNo { get; set; }

        public string AccountKey { get; set; }

        public bool IsDelete { get; set; }

    }
}
