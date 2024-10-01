using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    [Table("Persons")]
    public class Person 
    {
        [Key]
        public string PersonID { get; set;} // Căn cươc công dân
        public string FullName { get; set;} // Họ tên
        public string Address { get; set;} // Quê quán
    }
}
