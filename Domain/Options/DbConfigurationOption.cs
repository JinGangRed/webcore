using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Options
{
    public class DbConfigurationOption
    {
        public const string DbConfiguration = "DBConfiguration";
        public string ConnectionString { get; set; }

        [EnumDataType(typeof(DbType))]
        public DbType Type { get; set; }
    }

    public enum DbType
    {
        MSSQL,
        MYSQL,
    }
}
