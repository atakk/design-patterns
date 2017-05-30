using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Creational
{
    public enum PlatformType { Platform1, Platform2 }
    public enum ProductType { Product1, Product2 }

    public abstract class Product {
        public abstract string GetName();
    }

    public abstract class Product1: Product { }

    public class Product1Platform1 : Product1
    {
        public override string GetName()
        {
            return "Product1Platform1";
        }
    }
    public class Product1Platform2 : Product1
    {
        public override string GetName()
        {
            return "Product1Platform2";
        }
    }
    
    public abstract class Product2: Product { }

    public class Product2Platform1 : Product2
    {
        public override string GetName()
        {
            return "Product2Platform1";
        }
    }
    public class Product2Platform2 : Product2
    {
        public override string GetName()
        {
            return "Product2Platform2";
        }
    }

    public abstract class AbstractFactory
    {
        private static AbstractFactory _factoryPlatform1 = new FactoryPlatform1();
        private static AbstractFactory _factoryPlatform2 = new FactoryPlatform2();

        protected AbstractFactory() { }

        public static AbstractFactory GetFactory(PlatformType platformType)
        {
            switch (platformType)
            {
                case PlatformType.Platform1:
                    return _factoryPlatform1;
                case PlatformType.Platform2:
                    return _factoryPlatform2;
                default:
                    return null;
            }
        }

        public abstract Product CreateProduct(ProductType productType);

    }

    public class FactoryPlatform1 : AbstractFactory
    {
        public override Product CreateProduct(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.Product1:
                    return new Product1Platform1();
                case ProductType.Product2:
                    return new Product2Platform1();
                default:
                    return null;
            }
        }
    }
    public class FactoryPlatform2 : AbstractFactory
    {
        public override Product CreateProduct(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.Product1:
                    return new Product1Platform2();
                case ProductType.Product2:
                    return new Product2Platform2();
                default:
                    return null;
            }
        }
    }
}
