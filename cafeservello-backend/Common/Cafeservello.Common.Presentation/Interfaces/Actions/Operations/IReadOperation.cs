using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Common.Presentation.Interfaces.Actions.Operations
{
    public interface IReadOperation
    {
        Task<IActionResult> GetAllAsync();
    }
}
