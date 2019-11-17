using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Kutuphane
{
    class Kutuphane
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YayinEvi { get; set; }
        public string BaskiSayisi { get; set; }
        public string SayfaSayisi { get; set; }
        public string BasimYili { get; set; }
        public string Tur { get; set; }
        public string ISBN { get; set; }
        public override string ToString()
        {
            return $"{this.KitapAdi} - {this.YazarAdi}";
        }
        
    }
}
