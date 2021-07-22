using ElectoralRegisterApi.V1.Boundary.Response;

namespace ElectoralRegisterApi.V1.UseCase.Interfaces
{
    public interface IGetAllUseCase
    {
        ResponseObjectList Execute();
    }
}
