using System.ComponentModel.DataAnnotations;

namespace e_commerceApp.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        public String? CategoryName { get; set; } = String.Empty;
        
        public ICollection<Product> products { get; set; }

    }
}