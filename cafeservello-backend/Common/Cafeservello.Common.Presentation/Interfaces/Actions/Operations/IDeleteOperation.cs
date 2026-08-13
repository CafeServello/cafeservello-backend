using Microsoft.AspNetCore.Mvc;

namespace Cafeservello.Common.Presentation.Interfaces.Actions.Operations
{
    public interface IDeleteOperation<T>
    {
        Task<IActionResult> DeleteAsync(Guid id);
    }
}
