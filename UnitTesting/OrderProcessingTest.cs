using NUnit.Framework;
using OrderProcessing.MembershipService;
using OrderProcessing.Modals;
using OrderProcessing.Service;
using OrderProcessing.Services;
using System;

namespace UnitTesting
{
    [TestFixture]
    public class OrderProcessingTest
    {
        private IPackingSlip _packingSlip;
        private IMembership _membership;
        private ICommisionService _commisionService;
        private IOderProcessingService _orderService;
        [SetUp]
        public void Setup()
        {
            _packingSlip = new PackingSlip();
            _membership = new MembershipService();
            _commisionService = new CommisionService();
            _orderService = new OrderProcessingService(_packingSlip, _membership, _commisionService);
        }
        [TestCase(2, PaymentFor.PhysicalProduct, "", 2342.90, false)]
        [TestCase(31, PaymentFor.Membership, "", 999, false)]
        [TestCase(23, PaymentFor.Video, "", 560, false)]

        public void OrderPlacing_Test(int quantity, PaymentFor paymentCategory, string Name, decimal price, bool IsActive)
        {
            var objModal = new OrderProcessingModal
            {
                IsShipped = false,
                IsActive = true,
                Name = Name,
                OrderDate = new DateTime(),
                PaymentCategory = paymentCategory,
                Quantity = quantity,
                Price = price,
            };

            var objValidator = ObjectModalValidator.Validate(objModal);

            Assert.AreEqual(0, objValidator.Count);
            var result = _orderService.OrderPlacing(objModal);

            Assert.IsNotNull(result);
        }
    }
}
