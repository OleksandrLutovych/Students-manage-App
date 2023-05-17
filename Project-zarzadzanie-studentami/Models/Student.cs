using System.ComponentModel.DataAnnotations;

namespace Project_zarzadzanie_studentami.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int AlbumNumber { get; set; }
    }
}
