using AutoMapper;
using Reserver.DTOs.EquipmentCategory;
using Reserver.DTOs.Location;
using Reserver.DTOs.MaintenancePeriod;
using Reserver.DTOs.Reservation;
using Reserver.DTOs.Resource;
using Reserver.DTOs.ResourceCategory;
using Reserver.Entities;

namespace Reserver.Additional;

public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        
        
     
        /*
       CreateMap<User, UserCreateDto>().ReverseMap()
           .ForMember(dest=> dest.Password, opt=>opt.MapFrom(src => BCrypt.Net.BCrypt.HashPassword(src.Password)))//Encrypts the password
           ;

        */

        #region Resources
        
        //GetResource DTO
        
        CreateMap<GetResourcesDto, Resource>().ReverseMap()
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location.Name));

        CreateMap<GetResourcesDto, Resource>().ReverseMap()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name));
        
        //GetAResource DTO
        
        CreateMap<GetAResourceDto, Resource>().ReverseMap()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location.Name))
            .ForMember(dest => dest.ResourceType, opt => opt.MapFrom(src => src.ResourceType.ToString()))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));

        
        //CreateResourceDTO
        CreateMap<CreateResourceDTO, Resource>().ReverseMap();
        
        //UpdateResourcesDto
        CreateMap<UpdateResourcesDto, Resource>()
            .ForAllMembers(opt =>
                opt.Condition((src, dest, srcMember) => srcMember != null));
        
        #endregion

        
        
        
        #region Reservation 
        
        CreateMap<GetReservationDtoBrief, Reservation>().ReverseMap()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));

        
        
        #endregion
        
        
        #region Maintenance

        CreateMap<GetMaintenancePeriodsDTOBrief, MaintenancePeriod>().ReverseMap();
        



        #endregion
        
        
        #region Equipment Category
        CreateMap<CreateEquipmentCategoryDto, EquipmentCategory>().ReverseMap();
        
        #endregion
        
        #region Location
        CreateMap<CreateLocationDto, Location>().ReverseMap();
        
        
        #endregion

        #region Resource Category
        CreateMap<CreateResourceCategoryDto, ResourceCategory>().ReverseMap();
        

        #endregion
    }
}