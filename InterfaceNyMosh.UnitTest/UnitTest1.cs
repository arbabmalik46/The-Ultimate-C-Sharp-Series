using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using InterfacesByMosh;


namespace InterfaceNyMosh.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_Exception()
        {
            //var orderProcess = new OrderProcessor();
        }
    }
}
