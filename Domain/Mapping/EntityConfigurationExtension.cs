using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Domain.Mapping
{
    public static class EntityConfigurationExtension
    {
        public static ModelBuilder ApplyEntityConfigurations(this ModelBuilder builder)
        {
            var typeToRegisiter = Assembly.GetExecutingAssembly().GetMappingTypes(typeof(IEntityTypeConfiguration<>));
            foreach (var type in typeToRegisiter)
            {
                dynamic instance = Activator.CreateInstance(type);
                builder.ApplyConfiguration(instance);
            }
            return builder;
        }
        private static IEnumerable<Type> GetMappingTypes(this Assembly assembly,Type mappingType)
        {
            return assembly.GetTypes().Where(x => !x.IsAbstract && x.GetInterfaces().Any(y => y.GetTypeInfo().IsGenericType && y.GetGenericTypeDefinition() == mappingType));
        }
    }
}
