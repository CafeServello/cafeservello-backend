using Cafeservello.Common.Presentation.Controllers;
using Cafeservello.Modules.Domain.Users.Entities.User;
using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Modules.Presentation.Users.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : BaseController<User>
    {
        public override async Task<IActionResult> GetAllAsync()
        {
            return Ok();
        }
        public override async Task<IActionResult> DeleteAsync(Guid id)
        {
            return Ok();
        }
        public override async Task<IActionResult> PostAsync(User entity)
        {
            return Ok();
        }
        public override async Task<IActionResult> UpdateAsync(Guid id, User entity)
        {
            return Ok(entity);
        }
    }
}
