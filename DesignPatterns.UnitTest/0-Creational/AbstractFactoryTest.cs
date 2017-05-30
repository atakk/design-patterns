using DesignPatterns.Library.Creational;
using NUnit.Framework;

namespace DesignPatterns.UnitTest.Creational
{
    [TestFixture]
   public class AbstractFactoryTest
    {
        [Test]
        public void GetFatctory()
        {
            AbstractFactory factory = AbstractFactory.GetFactory(PlatformType.Platform1);
            Assert.IsNotNull(factory);

            factory = AbstractFactory.GetFactory(PlatformType.Platform2);
            Assert.IsNotNull(factory);
        }

        [TestCase(PlatformType.Platform1,ProductType.Product1, "Product1Platform1")]
        [TestCase(PlatformType.Platform1, ProductType.Product2, "Product2Platform1")]
        [TestCase(PlatformType.Platform2, ProductType.Product1, "Product1Platform2")]
        [TestCase(PlatformType.Platform2, ProductType.Product2, "Product2Platform2")]
        public void CreateProduct1(PlatformType platform, ProductType productType, string productName)
        {
            AbstractFactory factory = AbstractFactory.GetFactory(platform);
            Product product = factory.CreateProduct(productType);

            Assert.IsNotNull(product);
            Assert.AreEqual(productName,product.GetName());
        }

    }
}
