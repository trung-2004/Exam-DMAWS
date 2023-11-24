using System;

namespace Exam.DTOs
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int ItemQty { get; set; }
        public DateTime OrderDelivery { get; set; }
        public string OrderAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
