// Models/Order.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-incremented
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FullName { get; set; }

    [Required]
    [MaxLength(50)]
    public string FullAddress { get; set; }

    [Required]
    [MaxLength(50)]
    public string Email { get; set; }

    [Required]
    public string OrderDetailsJson { get; set; }
}
