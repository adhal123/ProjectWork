﻿using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of our class clsCustomer
            clsCustomer AnCustomer = new clsCustomer();
            //check to see that the class is not null
            Assert.IsNotNull(AnCustomer);
        }
    }
}
