using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookiesShop.Models
{
    public class Orders
    {
        [Key]
        public Guid id { get; set; } = Guid.NewGuid();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Precision(18, 2)]
        public decimal Totalprice { get; set; }

        
        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public Users users { get; set; }
    }
}
