using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using ProspektusService.DataObjects;
using ProspektusService.Models;

namespace ProspektusService.Controllers
{
    public class IlacController : TableController<Ilac>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            ProspektusContext context = new ProspektusContext();
            DomainManager = new EntityDomainManager<Ilac>(context, Request);
        }

        // GET tables/Ilac
        public IQueryable<Ilac> GetAllIlac()
        {
            return Query(); 
        }

        // GET tables/Ilac/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Ilac> GetIlac(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Ilac/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Ilac> PatchIlac(string id, Delta<Ilac> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Ilac
        public async Task<IHttpActionResult> PostIlac(Ilac item)
        {
            Ilac current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Ilac/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteIlac(string id)
        {
             return DeleteAsync(id);
        }
    }
}
