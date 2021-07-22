using System.Collections.Generic;
using ElectoralRegisterApi.V1.Domain;

namespace ElectoralRegisterApi.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(int id);

        List<Entity> GetAll();
    }
}
