using Domain.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Domain.Contexts
{
    public partial class AppDbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyEntityConfigurations();
            base.OnModelCreating(modelBuilder);
        }
    }
}
