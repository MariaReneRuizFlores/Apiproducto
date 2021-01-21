using System.Data.Entity;

namespace Apiproducto.Models
{
    public class DataContext: DbContext //escribimos :DbContext y control punto
    {
        //ctor tab tab
        public DataContext():base("DefaultConnection") //escribimos :base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Apiproducto.Models.Product> Products { get; set; }
    }
}