using OrderProcessing.MembershipService;
using OrderProcessing.Modals;
using OrderProcessing.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Service
{
    public class OrderProcessingService : IOderProcessingService
    {
        private readonly IPackingSlip _packingSlip;
        private readonly IMembership _membership;
        private readonly ICommisionService _commisionService;
        public OrderProcessingService(IPackingSlip packingSlip, IMembership membership, ICommisionService commisionService)
        {
            _packingSlip = packingSlip;
            _membership = membership;
            _commisionService = commisionService;
        }

        public bool OrderPlacing(OrderProcessingModal modal)
        {
            try
            {
                //ToDo: Logic to add the order into table. 
                // now check the payment for product category

                switch (modal.PaymentCategory)
                {
                    case PaymentFor.PhysicalProduct:
                        _packingSlip.GeneratePackingSlip(new PackingslipForShippingModal());
                        _commisionService.PayCommision();
                        break;
                    case PaymentFor.Membership:
                        _membership.AddUpdateMembership(new MembershipModal());
                        break;
                    case PaymentFor.Video:
                        // add the logic according to the norms... 
                        break;
                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                //ToDo: Handle the exception
            }
        }

    }
}
