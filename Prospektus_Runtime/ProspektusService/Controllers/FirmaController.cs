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
    public class FirmaController : TableController<Firma>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            ProspektusContext context = new ProspektusContext();
            DomainManager = new EntityDomainManager<Firma>(context, Request);
        }

        // GET tables/TodoItem
        public IQueryable<Firma> GetAllFirmas()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Firma> GetFirma(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Firma> PatchFirma(string id, Delta<Firma> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostFirma(Firma item)
        {
            Firma current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteFirma(string id)
        {
            return DeleteAsync(id);
        }
    }
}