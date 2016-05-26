using AutoMapper;
using Avam.DigiCura.Data.Repositories;
using Avam.DigiCura.NgOne.UI.Models;
using Avam.DigiCura.NgOne.UI.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Avam.DigiCura.NgOne.UI.Controllers
{
    public class CategoryController : DigiCuraControllerBase
    {
        #region Private Fields
        private readonly ICategoryRepository _repository;
        #endregion

        #region ctor
        public CategoryController()
        {
            _repository = new CategoryRepository();
        }
        #endregion

        #region Action Methods
        public ActionResult Index()
        {
            var items = _repository.FetchAll();
            IEnumerable<CategoryViewModel> modelItems = 
                Mapper.Map<IEnumerable<CategoryViewModel>>(items);
            return View(modelItems);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpNotFoundResult("Category identifier is missing");
            var category = _repository.FindById(id.Value);
            if (category == null) return new HttpNotFoundResult("Category not found");
            return View(Mapper.Map<CategoryViewModel>(category));
        }
        #endregion

        #region Helper Methods
        protected override void Dispose(bool disposing)
        {
            Check.ExecuteIfTrue(_repository!=null,()=> _repository.Dispose());
            base.Dispose(disposing);
        }
        #endregion
    }
}