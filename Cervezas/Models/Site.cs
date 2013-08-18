using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Cervezas.Models
{
    public class Site
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [MaxLength(256)]
        [Required]
        [DisplayName("Domain Name")]
        public string DomainName { get; set; }
    }
}