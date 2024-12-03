using AutoMapper;
using ParkingAppSolution.BL.Client.Entity;
using ParkingAppSolution.Repository;
using ParkingAppSolution.DataAccess.Entities;

namespace ParkingAppSolution.BL.Client.Manager;

public class ClientManager : IClientManager
{

    private readonly IRepository<ClientEntity> ClientRepository;
    private readonly IMapper _mapper;

    public ClientManager(IRepository<ClientEntity> ClientRepository, IMapper mapper)
    {
        ClientRepository = ClientRepository;
        _mapper = mapper;
    }

    public ClientModel CreateClient(CreateClientModel createModel)
    {
        if (string.IsNullOrEmpty(createModel.Email) || string.IsNullOrEmpty(createModel.PasswordHash))
        {
            throw new ArgumentException("Email and PasswordHash are required.");
        }

        ClientEntity entity;

        entity = _mapper.Map<ClientEntity>(createModel);
        

        entity = ClientRepository.Save(entity);
        return _mapper.Map<ClientModel>(entity);
    }

    public void DeleteClient(int id)
    {
        var entity = ClientRepository.GetById(id);
        if (entity == null)
        {
            throw new Exception($"Client with ID {id} not found.");
        }

        ClientRepository.Delete(entity);
    }

    public ClientModel UpdateClient(UpdateClientModel updateModel)
    {
        if (updateModel.Id <= 0)
        {
            throw new ArgumentException("Invalid Client ID.");
        }

        ClientEntity entity;

        entity = _mapper.Map<ClientEntity>(updateModel);
       

        entity = ClientRepository.Save(entity);
        return _mapper.Map<ClientModel>(entity);
    }
}