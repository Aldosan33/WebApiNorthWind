using System.Net;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace NorthWind.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [SwaggerResponse((int)HttpStatusCode.InternalServerError, "Server Error", typeof(ProblemDetails))]
    public abstract class ApiController : ControllerBase
    {
    }
}
