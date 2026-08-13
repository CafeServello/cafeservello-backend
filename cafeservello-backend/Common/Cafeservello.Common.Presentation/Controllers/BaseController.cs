using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Common.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected async Task<IActionResult> InvokeMethodAsync<T>(Func<Task<T>> method)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                return Ok(await method());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        protected async Task<IActionResult> InvokeMethodAsync(Func<Task> method)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await method();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
