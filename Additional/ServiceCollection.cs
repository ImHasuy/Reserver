using Reserver.Interfaces;
using Reserver.Services;

namespace Reserver.Additional;

public static class ServiceCollection
{
    public static void AddServices(this IServiceCollection services)
    {
        //services.AddScoped<INationalMinorityService, NationalMinorityService>();
        services.AddScoped<IResourceService, ResourceService>();
        services.AddScoped<IEquipmentCategoryService, EquipmentCategoryService>();
        services.AddScoped<ILocationService, LocationService>();
        services.AddScoped<IResourceCategoryService, ResourceCategoryService>();
        services.AddScoped<IRoomService, RoomService>();
        services.AddScoped<IEquipmentService, EquipmentService>();
        
        
        
        
        
        services.AddHttpContextAccessor();
    }
}