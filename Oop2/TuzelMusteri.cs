using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //miras inheritance
    class TuzelMusteri:Musteri //tüzel müşterinin ebeveyni:müşteridir. müşteride olan her şey tüzel müşteride de kabul edilir.
    {

        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
