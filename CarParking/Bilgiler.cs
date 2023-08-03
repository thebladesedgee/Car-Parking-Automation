using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    internal class Bilgiler
    {
        [Key]
        public int id { get; set; }
        public string plaka { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string araçtipi { get; set; }
        public string araçmarka { get; set; }
        public string araçmodel { get; set; }
        public string araçsaatgiriş { get; set; }
        public string araçsaatçıkış { get; set; }
        public string araçucret { get; set; }


    }
}
