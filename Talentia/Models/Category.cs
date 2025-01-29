using System.ComponentModel.DataAnnotations;

namespace Talentia.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "Ürün Kategorisi")]
        public string? CategoryName { get; set; }    
        virtual public List<Products>? Products { get; set;}
        
    }
}
