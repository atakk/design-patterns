using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Library.Creational.Builder;

namespace DesignPatterns.UnitTest.Creational
{
    [TestFixture]
    public class BuilderTest
    {
        [Test]
        public void BuildProduct()
        {
            Product1Builder productBuilder = new Product1Builder();
            Builder builder = new Builder(productBuilder);

            Product product = builder.GetProduct();
            Assert.IsNull(product);

            builder.CreateProduct();
            product = builder.GetProduct();
            Assert.IsNotNull(product);
        }

        [Test]
        public void BuildTwoProducts()
        {
            Product1Builder productBuilder = new Product1Builder();
            Product2Builder product2Builder = new Product2Builder();

            Builder builder = new Builder(productBuilder);
            builder.CreateProduct();
            Product product = builder.GetProduct();
            Assert.IsNotNull(product);
            Assert.AreEqual(0,product.Total);

            builder = new Builder(product2Builder);
            builder.CreateProduct();
            product = builder.GetProduct();
            Assert.IsNotNull(product);
            Assert.AreEqual(5, product.Total);
        }
    }
}
