using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Cervezas.Models
{
    public class Site
    {
        public int Id { get; set; }

        [MaxLength(256)]
        [Required]
        public string DomainName { get; set; }
    }
}