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
    public class ProspektusController : TableController<Prospektus>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            ProspektusContext context = new ProspektusContext();
            DomainManager = new EntityDomainManager<Prospektus>(context, Request);
        }

        // GET tables/TodoItem
        public IQueryable<Prospektus> GetAllProspektuss()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Prospektus> GetProspektus(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Prospektus> PatchProspektus(string id, Delta<Prospektus> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostProspektus(Prospektus item)
        {
            Prospektus current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteProspektus(string id)
        {
            return DeleteAsync(id);
        }
    }
}