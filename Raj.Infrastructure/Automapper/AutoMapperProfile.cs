using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


namespace Raj.Infrastructure.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            LoadAllMappings();
        }

        private void LoadAllMappings()
        {
            var listTypes = AppDomain.CurrentDomain.GetAssemblies()
                .Where(o => o.GetName().Name.Split('.').FirstOrDefault() == Assembly.GetExecutingAssembly().GetName().Name.Split('.').FirstOrDefault())
                .Select( o => o.GetExportedTypes())
                .ToList();


            var types = new List<Type>();
            listTypes.ForEach(l =>
            {
                types.AddRange(l);
            });

            var mapsFrom = (
                    from type in types
                    from instance in type.GetInterfaces()
                    where
                        typeof(IMapperProfile).IsAssignableFrom(type) &&
                        !type.IsAbstract &&
                        !type.IsInterface
                    select type).ToList();



            foreach (var map in mapsFrom)
            {
               var obj = (IMapperProfile)Activator.CreateInstance(map,this);
            }
        }

    }
}
