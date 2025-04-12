using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string GuestName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string GuestEmail { get; set; } = string.Empty;

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        // Navigation property
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
} 