namespace ExamplePortal.Controllers
{
    using App.Builders;
    using App.Models;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            var products = FetchProducts();

            return this.View(ProductBuilder.Decorate(products));
        }

        #region /// Internal ///////////////////////////////////////////////////

        private static IEnumerable<Product> FetchProducts()
        {
            return new[]
            {
                new Product { Title = "First product" },
                new Product { Title = "Second product" },
                new Product { Title = "Third product" },
            };
        }

        #endregion
    }
}
