using System;
using System.Collections.Generic;
using System.Text;

namespace IlacProspektusu.Model
{
    public class Prospektus
    {
        public string Id { get; set; }
        public string IlacId { get; set; }
        public string Formul { get; set; }
        public string Farmakolojik { get; set; }
        public string Endikasyon { get; set; }
        public string Kontrendikasyonlar { get; set; }
        public string Uyari { get; set; }
        public string YanEtki { get; set; }
        public string Etkilesim { get; set; }
        public string KullanimSekli { get; set; }
        public string Diger { get; set; }
        public string DozAsimi { get; set; }
    }
}
