using Domain.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Domain.Contexts.Factories
{
    public abstract class DesignTimeDbContextFactory<T> : IDesignTimeDbContextFactory<T> where T : DbContext
    {
        public T CreateDbContext(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",true)
                .AddJsonFile($"appsettings.{environment}.json",true)
                .Build();
            var dbConfigOption = new DbConfigurationOption();
            configuration.GetSection(DbConfigurationOption.DbConfiguration).Bind(dbConfigOption);

            var builder = new DbContextOptionsBuilder<T>();
            switch (dbConfigOption.Type)
            {
                case DbType.MSSQL:
                    builder.UseSqlServer(dbConfigOption.ConnectionString);
                    break;
                case DbType.MYSQL:
                    break;
                default:
                    break;
            }
            return (T)Activator.CreateInstance(typeof(T), builder.Options);
        }
    }
}
