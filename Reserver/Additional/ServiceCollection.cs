namespace Reserver.Additional;

public static class ServiceCollection
{
    public static void AddServices(this IServiceCollection services)
    {
        //services.AddScoped<INationalMinorityService, NationalMinorityService>();
        
        
        
        services.AddHttpContextAccessor();
    }
}