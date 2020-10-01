using OrderProcessing.Modals;
using OrderProcessing.Services;

namespace OrderProcessing.Service
{
    public class PackingSlip : IPackingSlip
    {
        public void GeneratePackingSlip(PackingslipForShippingModal objModal)
        {
            // add the logic to handle the PackingSlip... 
            // It may vary company to company....
        }
    }
}
