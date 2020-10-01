using OrderProcessing.Modals;
using System.Threading.Tasks;

namespace OrderProcessing.MembershipService
{
    public interface IMembership
    {
        Task<bool> AddUpdateMembership(MembershipModal objModal);
    }
}
