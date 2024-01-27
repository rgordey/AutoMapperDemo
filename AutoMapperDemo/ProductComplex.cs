using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMapperDemoData;

public class ProductComplex
{
    [Key]
    public Guid Id { get; set; }
    [MaxLength(50)]
    public string SKU { get; set; } = default!;
    [Column(TypeName = "decimal(5, 2)")]
    public decimal Price { get; set; }
    public Dimension Dimension { get; set; } = new Dimension();
}