using System.ComponentModel.DataAnnotations;

namespace AutoMapperDemoData;

public class ProductComplex
{
    [Key]
    public Guid Id { get; set; }

    public string SKU { get; set; } = default!;
    public decimal Price { get; set; }
    public Dimension Dimension { get; set; }
}