using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Alltech.DataAccess;
using AutoMapper;


namespace Alltech.Api.Repository
{
    public class EntityMapperCategory<TSource, TDestination> where TSource : class where TDestination : class
    {
        public EntityMapperCategory()
        {
            
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DataAccess.Models.Category, Models.CategoryModelMapper>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new DataAccess.Models.Category();
            var dest = mapper.Map<DataAccess.Models.Category, Models.CategoryModelMapper>(source);
        }

    }
}