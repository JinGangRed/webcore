using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contexts
{
    public partial class AppDbContext
    {
        public DbSet<Account> Account { get; set; }
    }
}
