using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Modals
{
    public class OrderProcessingModal
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Offers { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public PaymentFor PaymentCategory { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public bool IsShipped { get; set; }
    }



    public enum ProductCategory
    {
        Physical,
        Delicated,
    }

    public enum PaymentFor
    {
        PhysicalProduct,
        Membership,
        Video
    }
}
