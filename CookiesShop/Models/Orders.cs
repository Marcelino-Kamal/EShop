using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookiesShop.Models
{
    public class Orders
    {
        [Key]
        public int id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Precision(18, 2)]
        public decimal Totalprice { get; set; }

        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public Users users { get; set; }
    }
}
