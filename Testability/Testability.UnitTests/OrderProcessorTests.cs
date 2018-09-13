using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability.UnitTests
{
    // Name tests based on WHAT you are testing.
    [TestClass]
    public class OrderProcessorTests
    {
        // Naming Convention: METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        // need to outline the exception expected, outlined manually at CLASS LEVEL
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            // You will need to add a reference to the Testability project so that we can use classes outlined there.
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            // creating an order that is already shipped...
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);
            // IsTrue for booleans
            Assert.IsTrue(order.IsShipped);
            // args are expected, then actual
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
