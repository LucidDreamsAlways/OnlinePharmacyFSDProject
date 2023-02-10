using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet the requirements")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|7|8|9)\d{7}", ErrorMessage = "Phone Number is not valid")]
        public int Phone_NO { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Address does not meet the requirements")]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email address is not valid")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
