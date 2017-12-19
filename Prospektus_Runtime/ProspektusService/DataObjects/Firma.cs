using Microsoft.Azure.Mobile.Server;
using System.Collections.Generic;

namespace ProspektusService.DataObjects
{
    public class Firma:EntityData
    {
        public string Ad { get; set; }

        public List<Ilac> Ilacs { get; set; }

        public Firma()
        {
            Ilacs = new List<Ilac>();
        }
    }
}