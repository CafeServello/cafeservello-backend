using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Common.Presentation.Interfaces.Actions.Operations
{
    public interface IUpdateOperation<T>
    {
        Task<IActionResult> UpdateAsync( T entity, Guid id);
    }
}
