using System.ComponentModel.DataAnnotations;

namespace CookiesShop.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
    }
}
