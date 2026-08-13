using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Common.Presentation.Interfaces.Actions.Operations
{
    public interface IReadOperation<T>
    {
        Task<IActionResult> GetAllAsync();
    }
}
