using BisunessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeGamePoint2.ViewComponents.Category
{
    public class CategoryList: ViewComponent
    {

        CategoryBl categorybl = new CategoryBl(new EfCategoryDal());

        public IViewComponentResult Invoke()
        {
            var values = categorybl.TGetList();
            return View(values);
        }
    }
}
