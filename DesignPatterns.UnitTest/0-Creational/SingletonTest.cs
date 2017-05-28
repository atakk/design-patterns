using DesignPatterns.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTest.Creational
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void NotNullTest()
        {
            Singleton singleton = Singleton.GetInstance();

            Assert.IsNotNull(singleton);
        }

        [TestMethod]
        public void GetTwoInstancesTest()
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            Assert.AreSame(singleton2, singleton1);
        }
    }
}