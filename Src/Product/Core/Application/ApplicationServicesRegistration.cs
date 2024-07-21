namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection ApplicationServicesRegistration(this IServiceCollection services, IConfiguration configuration)
        {


            var application = typeof(IAssemblyMarker);

            services.AddMediatR(configure =>
            {
                configure.RegisterServicesFromAssembly(application.Assembly);
            });


            return services;
        }
    }
}
