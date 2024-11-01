using System.ComponentModel.DataAnnotations;

namespace Employedataproject.Models
{
    public class Employee
    {
        [Key]
        public int Empid { get; set; }
        public string  EmpName { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public byte[] Image { get; set; }

    }
}