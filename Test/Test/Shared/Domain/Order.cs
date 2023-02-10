using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public DateTime OrderDateTime { get; set; }
        public DateTime OrderDeliveryDate { get; set; }

        [Required]
        public int Order_Qty { get; set; }

        [Required]
        public string Payment_Type { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
