using System.ComponentModel.DataAnnotations;

namespace Project_zarzadzanie_studentami.Models
{
    public class Subject
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TypeOfSubject { get; set; }
        [Required]
        public TypeOfPass TypeOfPass { get; set; }
    }
    public enum TypeofSubject { Wyklad, Laboratorium, Czwiczenie }
    public enum TypeOfPass { Onte, Project, Kolokwium }
}
