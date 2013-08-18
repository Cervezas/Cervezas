using System.Data.Entity;

namespace Cervezas.Models
{
    public class Db : DbContext
    {
        public IDbSet<Site> Sites { get; set; } 
    }
}