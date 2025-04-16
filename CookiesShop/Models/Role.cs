using System.ComponentModel.DataAnnotations;

namespace CookiesShop.Models
{
    public class Role
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
