using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ParkingAppSolution.DataAccess.Entities;
using ParkingAppSolution.BL.Client.Entity;
using ParkingAppSolution.BL.Client.Manager;
using ParkingAppSolution.BL.Client.Provider;

namespace Parking.Controllers.Entities;


[ApiController]
[Route("[controller]")]
public class ClientsController : ControllerBase
{
    private readonly IClientManager _ClientsManager;
    private readonly IClientProvider _ClientsProvider;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public ClientsController(IClientManager ClientsManager, IClientProvider ClientsProvider,
        IMapper mapper, ILogger logger)
    {
        _ClientsManager = ClientsManager;
        _ClientsProvider = ClientsProvider;
        _mapper = mapper;
        _logger = logger;
    }


}