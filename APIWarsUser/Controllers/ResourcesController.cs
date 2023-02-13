using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWarsUser.Controllers
{
    [Route("api/resources")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        private readonly IResources _IResources;
        public ResourcesController(IResources IResources)
        {
            _IResources = IResources;
        }

        [HttpGet("{key}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IQueryable<AccountResources>> Get(string key) => await Task.FromResult(_IResources.GetResources(key));

    }
}
