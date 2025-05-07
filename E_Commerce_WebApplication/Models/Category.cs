using System.ComponentModel.DataAnnotations;

namespace E_Commerce_WebApplication.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }


    }
}
