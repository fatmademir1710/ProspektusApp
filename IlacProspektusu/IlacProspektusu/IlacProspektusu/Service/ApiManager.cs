
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IlacProspektusu.Model;
using Microsoft.WindowsAzure.MobileServices;

namespace IlacProspektusu
{
    public class ApiManager
    {
        static ApiManager defaultInstance = new ApiManager();

        MobileServiceClient client;

        IMobileServiceTable<Ilac> tableIlac;
        IMobileServiceTable<Prospektus> tableProspektus;

        public ApiManager()
        {
            this.client = new MobileServiceClient(Constants.ApplicationURL);
            this.tableIlac = client.GetTable<Ilac>();
            this.tableProspektus = client.GetTable<Prospektus>();
        }

        public async Task<List<Ilac>> getAllList()
        {

            return await tableIlac.ToListAsync();
        }
        public static ApiManager DefaultManager
        {
            get {  return defaultInstance; }
            set { defaultInstance = value; }
        }

    }
}
