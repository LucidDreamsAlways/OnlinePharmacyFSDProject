using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet the requirements")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Manufacturer does not meet the requirements")]
        public string Manufacturer { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Category does not meet the requirements")]
        public string Category { get; set; }
    }
}
