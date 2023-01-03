using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiziFilmModel.Models
{
   public class Kullanıcı
    {
        [Key]
        public int KullanıcıID { get; set; }

        [StringLength(60), Required]
        public string KullanıcıAdi { get; set; }

        [StringLength(60), Required]
        public string KullanıcıSifre { get; set; }
    }
}
