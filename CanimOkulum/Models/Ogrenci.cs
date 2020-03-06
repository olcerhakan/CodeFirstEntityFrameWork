using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanimOkulum.Models
{
   public class Ogrenci
    {
        [Key]     // Pk auto increment icin  (OgrenciNo da artmaz. Id veya OgrenciId gormeliydi)
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OgrenciNo { get; set; }   //otomatik artması için
        [Required, MaxLength(20)]  // boş geçilemesin, ve max uzunluk 20 olsun
        public string Ad { get; set; }
        [MaxLength(30)]
        public string Soyad { get; set; }
    }
}
