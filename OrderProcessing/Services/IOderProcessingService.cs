using OrderProcessing.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Services
{
    public interface IOderProcessingService
    {
        bool OrderPlacing(OrderProcessingModal modal);
    }
}
