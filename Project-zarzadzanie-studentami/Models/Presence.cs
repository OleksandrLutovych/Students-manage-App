using Microsoft.Build.Framework;

namespace Project_zarzadzanie_studentami.Models
{
    public class Presence
    {
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string SubjectName { get; set; }
        [Required]
        public DateTime PresenceData { get; set; }
        [Required]
        public bool IsPresent { get; set; }
    }
}
