namespace ExamplePortal.App.Builders
{
    using Decorators;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class ProductBuilder
    {
        private static readonly string[] CssClassMap =
        {
            "red",
            "green",
            "blue",
        };

        public static IEnumerable<ProductDecorator> Decorate(
            IEnumerable<Product> products)
        {
            return products
                .Select(ProductDecorator.Default)
                .Select(AssignColor);
        }

        #region /// Internal ///////////////////////////////////////////////////

        private static ProductDecorator AssignColor(ProductDecorator product, int i)
        {
            product.Color = CssClassMap[i % CssClassMap.Length];
            return product;
        }

        #endregion
    }
}