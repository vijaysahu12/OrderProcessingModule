using OrderProcessing.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderProcessing.Modals
{
    public class MembershipModal
    {
        [Required]
        public int MembershipId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsActive { get; set; }


        public void SendEmail(string template, string from, string to)
        {
            Notification.SendEmail(template, from, to);
        }
    }

}
