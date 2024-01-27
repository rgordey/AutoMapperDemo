using System.ComponentModel.DataAnnotations;

namespace AutoMapperDemoUI
{
    public class ProductOwnedDto
    {
        [Key]
        public Guid Id { get; set; }

        public string SKU { get; set; } = default!;
        public decimal Price { get; set; }
        public DimensionDto Dimension { get; set; } = new DimensionDto();
    }
}
