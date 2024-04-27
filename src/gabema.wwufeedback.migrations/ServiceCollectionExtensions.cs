namespace gabema.wwufeedback.migrations;

using gabema.wwufeedback.domain.Models.Repositories;
using gabema.wwufeedback.migrations.Repositories;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection WithEfCoreContext(this IServiceCollection services)
    {
        services.AddScoped<ITopicRepository, EfCoreTopicRepository>();
        return services;
    }
}