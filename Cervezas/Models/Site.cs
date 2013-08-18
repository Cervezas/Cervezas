using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cervezas.Models
{
    public class Site
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [MaxLength(256)]
        [Required]
        public string Name { get; set; }

        [MaxLength(256)]
        [Required]
        [DisplayName("Domain Name")]
        public string DomainName { get; set; }

        public virtual List<Survey> Surveys { get; set; }

        public string FaviconUrl
        {
            get
            {
                return "http://g.etfv.co/http://" + DomainName;
            }
        }
    }
}