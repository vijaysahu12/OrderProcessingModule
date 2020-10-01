using System;
using NUnit.Framework;
using OrderProcessing.MembershipService;
using OrderProcessing.Modals;
using OrderProcessing.Service;

namespace UnitTesting
{
    [TestFixture]
    public class MembershipTestModel
    {
        IMembership membership;
        [SetUp]
        public void Setup()
        {
            membership = new MembershipService();
        }
        [TestCase(0, 0, null, null, null, false)]
        public void AddUpdateMemberShip_Test(int MembershipId, int CustomerId, string Name, DateTime StartDate, DateTime EndDate, bool IsActive)
        {
            var objModal = new MembershipModal
            {
                CustomerId = CustomerId,
                Name = Name,
                MembershipId = MembershipId,
                StartDate = StartDate,
                EndDate = EndDate,
                IsActive = IsActive,
            };

            var objValidator = ObjectModalValidator.Validate(objModal);

            Assert.AreEqual(0, objValidator.Count);
            var result = membership.AddUpdateMembership(objModal);

            Assert.IsNotNull(result);
        }
    }
}
