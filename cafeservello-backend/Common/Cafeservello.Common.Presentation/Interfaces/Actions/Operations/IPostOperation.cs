using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Common.Presentation.Interfaces.Actions.Operations
{
    public interface IPostOperation<T> 
    {
        Task<IActionResult> PostAsync(T entity);
    }
}
