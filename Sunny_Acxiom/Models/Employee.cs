using System.ComponentModel.DataAnnotations;

namespace Sunny_Acxiom.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        
        public string E_Name { get; set; }
        
        public string E_Email { get; set; }
        
        public string Department { get; set; }
    }
}
