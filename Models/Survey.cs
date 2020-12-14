using System.ComponentModel.DataAnnotations;
namespace dojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "Your Name:")]
        public string name{set;get;}
        
        [Required]
        [Display(Name = "Dojo Location:")]
        public string dojo{set;get;}

        [Required]
        [Display(Name = "Favorite Language:")]
        public string language{set;get;}

        [MaxLength(20)]
        [Display(Name = "Comment (optional):")]
        public string comment{set;get;}
    }
}