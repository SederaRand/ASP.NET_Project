using System.Web.Http;
using System.Collections.Generic;
using System.Web.Http.Results;
using Alltech.DataAccess.Models;
using Alltech.DataAccess.Intefaces;
using Alltech.Api.Repository;
using AutoMapper;



namespace Alltech.Api.Controllers
{
    public class CategoryController : ApiController
    {

        public ICategory DALCategory;

        public CategoryController()
        {
            
        }

        public CategoryController(ICategory dalCategory)
        {
            this.DALCategory = dalCategory;
        }

        // GET: Showroom  
        [HttpGet]
        public JsonResult<List<Models.CategoryModelMapper>> GetAllCategory()
        {

            EntityMapperCategory<Category, Models.CategoryModelMapper> mapObj = new EntityMapperCategory<Category, Models.CategoryModelMapper>();
            List<DataAccess.Models.Category> dalCategory = DALCategory.GetAllCategory();
            List<Models.CategoryModelMapper> categories = new List<Models.CategoryModelMapper>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, Models.CategoryModelMapper>());

            var mapper = new Mapper(config);
            foreach (var item in dalCategory)
            {
                categories.Add(mapper.Map<Models.CategoryModelMapper>(item));
            }
            return Json<List<Models.CategoryModelMapper>>(categories);
        }

        [HttpGet]
        public JsonResult<Models.CategoryModelMapper> GetCategory(int id)
        {
            EntityMapperCategory<DataAccess.Models.Category, Models.CategoryModelMapper> mapObj = new EntityMapperCategory<DataAccess.Models.Category, Models.CategoryModelMapper>();
            DataAccess.Models.Category dalCategory = DALCategory.GetCategory(id);
            Models.CategoryModelMapper categories = new Models.CategoryModelMapper();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, Models.CategoryModelMapper>());
            var mapper = new Mapper(config);

            categories = mapper.Map<Models.CategoryModelMapper>(dalCategory);
            return Json<Models.CategoryModelMapper>(categories);
        }
        [HttpPost]
        public bool InsertCategory(Models.CategoryModelMapper category)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                EntityMapperCategory<DataAccess.Models.Category, Models.CategoryModelMapper> mapObj = new EntityMapperCategory<DataAccess.Models.Category, Models.CategoryModelMapper>();
                DataAccess.Models.Category categoryObj = new DataAccess.Models.Category();
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.CategoryModelMapper, Category>());
                var mapper = new Mapper(config);
                categoryObj = mapper.Map<Category>(category);
                status = DALCategory.InsertCategory(categoryObj);
            }
            return status;
        }
        [HttpPut]
        public bool UpdateCategory(Models.CategoryModelMapper category)
        {
            EntityMapperCategory<Models.CategoryModelMapper, DataAccess.Models.Category> mapObj = new EntityMapperCategory<Models.CategoryModelMapper, DataAccess.Models.Category>();
            DataAccess.Models.Category categoryObj = new DataAccess.Models.Category();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.CategoryModelMapper, Category>());
            var mapper = new Mapper(config);
            categoryObj = mapper.Map<Category>(category);
            var status = DALCategory.UpdateCategory(categoryObj);
            return status;
        }
        [HttpDelete]
        public bool DeleteCategory(int id)
        {
            var status = DALCategory.DeleteCategory(id);
            return status;
        }




    }
}
