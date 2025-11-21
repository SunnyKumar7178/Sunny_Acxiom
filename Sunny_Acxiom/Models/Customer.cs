using System.ComponentModel.DataAnnotations;

namespace Sunny_Acxiom.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        
        public string C_Name { get; set; }
        public string City { get; set; }
        public string Phone_Number { get; set; }

        public string C_Email { get; set; } 
         

    }
}
