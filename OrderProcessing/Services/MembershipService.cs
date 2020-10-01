using OrderProcessing.MembershipService;
using OrderProcessing.Modals;
using System;
using System.Threading.Tasks;

namespace OrderProcessing.Service
{
    public class MembershipService : IMembership
    {

        public async Task<bool> AddUpdateMembership(MembershipModal objModal)
        {
            //write the lgoic to save into db 
            // once successfully save into db then shoot the mail...
            objModal.SendEmail("template", "to", "from");
            return true;
        }
    }
}
