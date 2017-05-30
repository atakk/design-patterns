using DesignPatterns.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTest.Creational
{
    [TestFixture]
    public class SingletonTest
    {
        [Test]
        public void NotNullTest()
        {
            Singleton singleton = Singleton.GetInstance();

            Assert.IsNotNull(singleton);
        }

        [Test]
        public void GetTwoInstancesTest()
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            Assert.AreSame(singleton2, singleton1);
        }
    }
}