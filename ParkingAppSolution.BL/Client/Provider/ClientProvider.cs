using AutoMapper;
using ParkingAppSolution.BL.Client.Entity;
using ParkingAppSolution.DataAccess.Entities;
using ParkingAppSolution.Repository;

namespace ParkingAppSolution.BL.Client.Provider;

public class ClientProvider : IClientProvider
{

    private readonly IRepository<ClientEntity> ClientRepository;
    private readonly IMapper _mapper;

    public ClientProvider(IRepository<ClientEntity> ClientRepository, IMapper mapper)
    {
        ClientRepository = ClientRepository;
        _mapper = mapper;
    }

    public IEnumerable<ClientModel> GetClients(FilterClientModel filter)
    {
        var query = ClientRepository.GetAll();

        if (!string.IsNullOrEmpty(filter.PhoneNumberPart))
        {
            query = query.Where(c => c.PhoneNumber.Contains(filter.PhoneNumberPart));
        }

        if (!string.IsNullOrEmpty(filter.EmailPart))
        {
            query = query.Where(u => u.Email.Contains(filter.EmailPart));
        }

        return query.Select(c => _mapper.Map<ClientModel>(c)).ToList();
    }

    public ClientModel GetClientById(int id)
    {
        var entity = ClientRepository.GetById(id);
        if (entity == null)
        {
            throw new Exception($"Client with ID {id} not found.");
        }
        return _mapper.Map<ClientModel>(entity);
    }

}