using System.ComponentModel.DataAnnotations;

namespace Cervezas.Models
{
    public class Question
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public int SurveyId { get; set; }
        public virtual Survey Survey { get; set; }

        [ScaffoldColumn(false)]
        public int DisplayOrder { get; set; }

        [Required]
        [MaxLength(1024)]
        public string Text { get; set; }
    }
}