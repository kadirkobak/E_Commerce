using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_WebApplication.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }


    }
}
