using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Common.Presentation.Interfaces.Actions.Operations
{
    public interface IDeleteOperation
    {
        Task<IActionResult> DeleteAsync(Guid id);
    }
}
