using Login_SignUp.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Login_SignUp.Models
{
    public class Product : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Item")]
        [Required(ErrorMessage = "The Product Name is Required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The Item name must be between 3 to 20 chars")]
        public string name { get; set; }
        [Display(Name = "Photo")]
        [Required(ErrorMessage = "The Product Photo is Required")]
        public string Logo { get; set; }
        [Display(Name = "Category")]
        [Required(ErrorMessage = "The Product Category is Required")]
        public string Category { get; set; }


        [Display(Name = "Specification")]
        [Required(ErrorMessage = "The Product Specification is Required")]
        public string Specification { get; set; }
        [Required(ErrorMessage = "The Product Price is Required")]
        public double Price { get; set; }
    }
}
