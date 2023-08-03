using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    internal class ArabaÜcretler
    {
        [Key]
        public int id { get; set; }
        public int OtomobilÜcret  { get; set; }
        public int KamyonÜcret { get; set; }
        public int OtobüsÜcret { get; set; }
        public int MotosikletÜcret { get; set; }
        public int AraziAraçlarıÜcret { get; set; }


    }
}
