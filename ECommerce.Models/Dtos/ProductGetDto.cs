namespace ECommerce.Models.Dtos
{
    public class ProductGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }
}