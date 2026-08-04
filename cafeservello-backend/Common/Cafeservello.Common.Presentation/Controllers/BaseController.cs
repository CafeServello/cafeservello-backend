using Cafeservello.Common.Presentation.Interfaces.Actions.Crud;
using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Common.Presentation.Controllers
{
    public abstract class BaseController<T> : ControllerBase, ICrudOperation<T>
    {
        [HttpGet]
        public virtual async Task<IActionResult> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public virtual async Task<IActionResult> PostAsync([FromBody] T entity)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> UpdateAsync(Guid id, [FromBody] T entity)
        {
            throw new NotImplementedException();
        }
    }
}
