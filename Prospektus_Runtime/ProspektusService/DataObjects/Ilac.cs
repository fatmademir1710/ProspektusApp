using Microsoft.Azure.Mobile.Server;

namespace ProspektusService.DataObjects
{
    public class Ilac:EntityData
    {
        public string ProspektusId { get; set; }
        public string Ad { get; set; }
        public int Barkod { get; set; }
        public decimal Fiyat { get; set; }
        public string FirmaId { get; set; }
        public virtual Prospektus Prospektus { get; set; }
        public virtual Firma Firma { get; set; }

    }
}