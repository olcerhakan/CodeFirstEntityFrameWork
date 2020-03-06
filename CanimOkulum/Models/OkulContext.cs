using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanimOkulum.Models
{
    public class OkulContext : DbContext
    {
        public OkulContext() : base("server=.; database=CanimOkulumDb; uid=sa; pwd=123")  // local db ye girmesin istiyorum
        {

        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
    }
}
