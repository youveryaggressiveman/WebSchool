﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Common.Mappings
{
    public class AssemblyMappingProfile : Profile
    {
        public AssemblyMappingProfile(Assembly assembly) =>
            ApplyMappingsFromAssembly(assembly);

        public void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(type => type.GetInterfaces()
                .Any(i => i.IsGenericType &&
                
                i.GetGenericTypeDefinition() == typeof(IMapWith<>)))
                .ToList();

            foreach (var item in types)
            {
                var instance = Activator.CreateInstance(item);
                var methodInfo = item.GetMethod("Mapping");
                
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
