using Cafeservello.Common.Presentation.Interfaces.Actions.Operations;

namespace Cafeservello.Common.Presentation.Interfaces.Actions.Crud
{
    public interface ICrudOperation<T> : IReadOperation<T>, IPostOperation<T>, IUpdateOperation<T>, IDeleteOperation<T>
    {

    }
}
