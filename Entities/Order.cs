using System.ComponentModel.DataAnnotations;

namespace WebshopAPI.Entities
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }

        //navigation properties

        public virtual Customer Customer { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
