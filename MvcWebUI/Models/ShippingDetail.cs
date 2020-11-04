using System.ComponentModel.DataAnnotations;

namespace MvcWebUI.Models
{
    public class ShippingDetail
    {
        //[Required(ErrorMessage ="Name Is Required" )]
        public string Firstname { get; set; }
        //[Required(ErrorMessage ="Last Name Is Required" )]

        public string Lastname { get; set; }
        //[Required]
        //[DataType(DataType.EmailAddress)]

        public string Email { get; set; }

        //[Required]
        public string City { get; set; }
        //[Required]
        //[DataType(DataType.MultilineText)]

        public string Address { get; set; }
        //[Required]
        //[Range(18,99)]
        public int Age { get; set; }
    }
}