using Cafeservello.Common.Presentation.Controllers;
using Cafeservello.Common.Presentation.Interfaces.Actions.Crud;
using Cafeservello.Modules.Application.Users.Interfaces;
using Cafeservello.Modules.Domain.Users.DTOs;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;

namespace Cafeservello.Modules.Presentation.Users.Controllers
{
    /// <summary>
    /// Controller for managing users.
    /// </summary>
    public class UsersController : BaseController, ICrudOperation<UserDTO>
    {
        private readonly IUserApp _userContext;

        public UsersController(IUserApp userApp) {
            _userContext = userApp;
        }
        /// <summary>
        /// Read all existing users
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return await InvokeMethodAsync(async () =>
            {
                var users = await _userContext.GetAllAsync();
                return Ok(users);
            });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var user = await _userContext.GetByIdAsync(id);

            return Ok(user);
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostAsync(UserDTO entity)
        {
            return await InvokeMethodAsync(async () =>
            {
                await _userContext.CreateAsync(entity);
            });
        }
        /// <summary>
        /// Update an existing user
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromBody] UserDTO entity, [FromRoute] Guid id)
        {

            return await InvokeMethodAsync(async () =>
            {
                var result = await _userContext.UpdateAsync(entity, id);
                return Ok(result); // Passa o objeto retornado para o Ok()
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

        
        

    }
}
