
using System.ComponentModel.DataAnnotations;

namespace Login_SignUp.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        public int Image { get; set; }
        public string Name { get; set; }
        public  int ContactDetails { get; set; }
        public string adress { get; set; }

        public List<Product> Products{ get; set; }

    }
}
