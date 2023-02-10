using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet the requirements")]
        public string Name { get; set; }

        [Required]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "IC Number does not meet the requirements")]
        public string IC_NO { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|7|8|9)\d{7}", ErrorMessage = "Phone Number is not valid")]
        public int Phone_NO { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public DateTime Hire_Date { get; set; }

        [Required]
        public int Salary { get; set; }
    }
}
