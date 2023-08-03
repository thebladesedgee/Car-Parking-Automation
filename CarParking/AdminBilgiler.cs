using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    internal class AdminBilgiler
    {
        [Key]
        public int id { get; set; }
        public string kullanıcıadı { get; set; }
        public string şifre { get; set; }

    }
}
