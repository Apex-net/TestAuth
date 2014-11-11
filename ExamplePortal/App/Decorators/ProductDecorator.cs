namespace ExamplePortal.App.Decorators
{
    using Models;

    public class ProductDecorator
    {
        private readonly Product model;

        private string cssClass;

        private ProductDecorator(Product model)
        {
            this.model = model;
        }

        public string Title
        {
            get { return this.model.Title; }
            set { this.model.Title = value; }
        }

        public string Color
        {
            get { return this.cssClass ?? "default"; }
            set { this.cssClass = value; }
        }

        public static ProductDecorator Default(Product model)
        {
            return new ProductDecorator(model);
        }
    }
}