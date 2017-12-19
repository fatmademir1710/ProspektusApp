using Microsoft.Azure.Mobile.Server;
using System.Collections.Generic;

namespace ProspektusService.DataObjects
{
    public class Prospektus:EntityData
    {
        public string IlacId { get; set; }
        public string Formul { get; set; }
        public string Farmakolojik { get; set; }
        public string Endikasyon { get; set; }
        public string Kontrendikasyonlar { get; set; }
        public string Uyari { get; set; }
        public string YanEtki { get; set; }
        public string Etkilesim { get; set; }
        public string KullanımSekli { get; set; }
        public string DozAsimi { get; set; }
        public bool ReceteliMi { get; set; }
        public virtual Ilac Ilac { get; set; }
        public List<EtkenMadde> EtkenMaddes { get; set; }

        public Prospektus()
        {
            EtkenMaddes = new List<EtkenMadde>();
        }
    }
}