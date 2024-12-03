using AutoMapper;
using ParkingAppSolution.BL.Client.Entity;
using ParkingAppSolution.DataAccess.Entities;

namespace ParkingAppSolution.BL.Mapper;

public class ClientBLProfile : Profile
{
    public ClientBLProfile()
    {
        CreateMap<ClientEntity, ClientModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.PasportNumber, opt => opt.MapFrom(src => src.PasportNumber))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest => dest.PersonalSale, opt => opt.MapFrom(src => src.PersonalSale))
            .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash));
        
        CreateMap<CreateClientModel, ClientModel>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.PasportNumber, opt => opt.MapFrom(src => src.PasportNumber))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest => dest.PersonalSale, opt => opt.MapFrom(src => src.PersonalSale))
            .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash));
        
        CreateMap<UpdateClientModel, ClientModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.PasportNumber, opt => opt.MapFrom(src => src.PasportNumber))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest => dest.PersonalSale, opt => opt.MapFrom(src => src.PersonalSale))
            .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash));
    }
}