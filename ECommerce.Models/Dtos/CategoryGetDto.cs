namespace ECommerce.Models.Dtos
{
    public class CategoryGetDto
    {
        public int Id { get; set; }
        public string CategoryName { private get; set; } = string.Empty;
        public string Category
        {
            get
            {
                var names = CategoryName.Split(' ');
                var newNames = new List<string>();
                foreach(var name in names)
                {
                    var n = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
                    newNames.Add(n);
                }
                return string.Join(" ", newNames);
            }
        }
    }
}