using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers // Shared BaseController across all the controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        // If _mediator exists assigns its value; Otherwise request for it and assign value
        // Using protected Mediator derives to other controllers classes
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    }
}