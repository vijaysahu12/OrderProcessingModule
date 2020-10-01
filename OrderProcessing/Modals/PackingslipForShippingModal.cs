using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Modals
{
    public class PackingslipForShippingModal
    {
        public PackingSlipType TypeOfPacking { get; set; }
        public decimal Weight { get; set; }

    }

    public enum PackingSlipType
    {
        Fresh,
        Duplicate
    }
}
