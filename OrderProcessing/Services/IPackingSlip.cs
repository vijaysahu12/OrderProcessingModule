using OrderProcessing.Modals;

namespace OrderProcessing.Services
{
    public interface IPackingSlip
    {
        void GeneratePackingSlip(PackingslipForShippingModal objModal);
    }
}
