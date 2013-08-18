using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cervezas.Models
{
    public class Survey
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        public int SiteId { get; set; }
        public virtual Site Site { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        public virtual List<Question> Questions { get; set; } 
    }
}