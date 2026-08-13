using Cafeservello.Common.Presentation.Controllers;
using Cafeservello.Common.Presentation.Interfaces.Actions.Crud;
using Cafeservello.Modules.Application.Users.Interfaces.Services;
using Cafeservello.Modules.Domain.Users.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Modules.Presentation.Users.Controllers
{
    /// <summary>
    /// Controller for managing users.
    /// </summary>
    public class UsersController : BaseController, ICrudOperation<UserDTO>
    {
        private readonly IUserApp _userApp;

        public UsersController(IUserApp userApp) {
            _userApp = userApp;
        }
        /// <summary>
        /// Read all existing users
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return await InvokeMethodAsync(async () =>
            {
                var users = await _userApp.GetAllAsync();
                return Ok(users);
            });
        }

        ///<summary>
        /// Soft Delete a user by its id
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            return await InvokeMethodAsync(async () =>
            {
                return Ok();
            });
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostAsync(UserDTO entity)
        {
            return await InvokeMethodAsync(async () =>
            {
                return Ok();
            });
        }

        /// <summary>
        /// Update an existing user
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, UserDTO entity)
        {
            return await InvokeMethodAsync(async () =>
            {
                return Ok();
            });
        }

    }
}
