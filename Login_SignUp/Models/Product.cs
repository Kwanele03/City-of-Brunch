using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login_SignUp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string   category { get; set; }
        public double Price { get; set; }

        //Relationships

        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Stores { get; set; }










    }
}
