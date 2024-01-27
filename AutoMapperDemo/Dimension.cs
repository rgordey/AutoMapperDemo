using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMapperDemoData;

public class Dimension
{
    [Column(TypeName = "decimal(5, 2)")]
    public decimal Height { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    public decimal Width { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    public decimal Depth { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    public decimal Weight { get; set; }
}