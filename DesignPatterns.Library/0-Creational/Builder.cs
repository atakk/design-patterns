using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Creational.Builder
{
    public class Product
    {
        public string Name { get; set; }
        public int Total { get; set; }
    }

  public abstract class ProductBuilder
    {
        protected Product _product;

        public void CreateProduct()
        {
            _product = new Product();
        }

        public Product GetProduct()
        {
            return _product;
        }

        public abstract void BuildName();
        public abstract void BuildTotal();
    }

    public class Product1Builder : ProductBuilder
    {
        public override void BuildName()
        {
            _product.Name = "Product1";
        }

        public override void BuildTotal()
        {
            _product.Total = 0;
        }
    }

    public class Product2Builder : ProductBuilder
    {
        public override void BuildName()
        {
            _product.Name = "Product2";
        }

        public override void BuildTotal()
        {
            _product.Total = 5;
        }
    }

   public class Builder
    {
        private ProductBuilder _productBuilder;

        public Builder(ProductBuilder productBuilder)
        {
            _productBuilder = productBuilder;
        }

        public void CreateProduct()
        {
            _productBuilder.CreateProduct();
            _productBuilder.BuildName();
            _productBuilder.BuildTotal();
        }

        public Product GetProduct()
        {
            return _productBuilder.GetProduct();
        }

    }
}
