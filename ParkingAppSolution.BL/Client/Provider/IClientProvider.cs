using ParkingAppSolution.BL.Client.Entity;

namespace ParkingAppSolution.BL.Client.Provider;

public interface IClientProvider
{
    IEnumerable<ClientModel> GetClients(FilterClientModel filterModel = null);
    ClientModel GetClientById(int id);
}