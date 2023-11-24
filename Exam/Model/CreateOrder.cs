using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exam.Model
{
    public class CreateOrder
    {
        [Required(ErrorMessage = "Please enter Code")]
        [MinLength(3, ErrorMessage = "Enter at least 3 characters")]
        [MaxLength(50, ErrorMessage = "Enter up to 50 characters")]
        public string ItemCode { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        [MinLength(3, ErrorMessage = "Enter at least 3 characters")]
        [MaxLength(200, ErrorMessage = "Enter up to 200 characters")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Please enter Quantity")]
        public int ItemQty { get; set; }

        [Required(ErrorMessage = "Please enter Delivery")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDelivery { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        public string OrderAddress { get; set; }

        [Required(ErrorMessage = "Please enter Phone")]
        [MinLength(10, ErrorMessage = "Enter at least 10 characters")]
        [MaxLength(12, ErrorMessage = "Enter up to 12 characters")]
        public string PhoneNumber { get; set; }
    }
}
