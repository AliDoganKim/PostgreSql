using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSql.Data.Entities
{
    [Table("Kullanici")]
    public class Kullanici
    {
        public int ID { get; set; }

        public string AdSoyad { get; set; }

        public string KullaniciAdi { get; set; }
    }
}
