namespace ECommerce.Models.Dtos
{
    public class ProductGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public float Price { get; set; }
        public string Category
        {
            get { return CategoryName.Substring(0, 1).ToUpper() + CategoryName.Substring(1).ToLower(); }
        }
    }
}