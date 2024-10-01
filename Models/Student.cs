

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    [Table("Students")]
    public class Student 
    {
        [Key]
        public string? StudentID { get; set;} //Căn cước công dân
        public string? FullName { get; set;} // Họ tên
        public string? Address { get; set;} // Quê quán
    }
}
