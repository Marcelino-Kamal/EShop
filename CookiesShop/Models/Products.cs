using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookiesShop.Models
{
    public class Products
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(255)]
        public string name { get; set; }

        public string description { get; set; }
        public string imgUrl {  get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal price { get;set; }

        [Required]
        public bool inStock { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category category { get; set; }


    }
}
