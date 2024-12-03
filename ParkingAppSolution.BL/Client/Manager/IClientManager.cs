using ParkingAppSolution.BL.Client.Entity;
using ParkingAppSolution.DataAccess.Entities;

namespace ParkingAppSolution.BL.Client.Manager;

public interface IClientManager
{
    ClientModel CreateClient(CreateClientModel ClientModel);
    void DeleteClient(int ClientId);
    ClientModel UpdateClient(UpdateClientModel UpdateModel);
}