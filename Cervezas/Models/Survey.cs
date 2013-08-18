using System.ComponentModel.DataAnnotations;

namespace Cervezas.Models
{
    public class Survey
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public int SiteId { get; set; }
        public virtual Site Site { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; }
    }
}