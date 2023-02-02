using e_Tech.Data.enums;
using eMediaStore.Data.Base;

namespace e_Tech.Models
{
    public class Products :IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public string status { get; set; }

        public ProductCategory category { get; set; }
    }
}
