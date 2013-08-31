using System.ComponentModel.DataAnnotations;

namespace botforge.Models
{
    public class LearnViewModel
    {
    
    }

    public class LessonViewModel
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Week #")]
        public int WeekNumber { get; set; }

        [Required]
        [Display(Name = "Lesson Title")]
        public string Title{get;set;}

        [Required]
        [Display(Name = "Cover Image")]
        public string LessonImage { get; set; }

        [Required]
        [Display(Name = "Summary")]
        public string Summary { get; set; }
    }
}