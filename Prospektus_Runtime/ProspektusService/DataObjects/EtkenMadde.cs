using Microsoft.Azure.Mobile.Server;

namespace ProspektusService.DataObjects
{
    public class EtkenMadde: EntityData
    {
        public string Ad { get; set; }
        public string ProspektusId { get; set; }
        public virtual Prospektus Prospektus { get; set; }
    }
}