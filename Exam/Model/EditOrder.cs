using System.ComponentModel.DataAnnotations;

namespace Exam.Model
{
    public class EditOrder
    {
        [Required(ErrorMessage = "Please enter Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Delivery")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDelivery { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        public string OrderAddress { get; set; }
    }
}
