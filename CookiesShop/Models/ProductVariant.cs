using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookiesShop.Models
{
    public class ProductVariant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public SizeOption Size { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Products Product { get; set; }
    }

    public enum SizeOption
    {
        Small,
        Medium,
        Large
    }
}
