using BlogCommentService.Application.Abstractions.Integrations.Users;
using BlogCommentService.Infrastructure.Grpc.Gateways;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BlogCommentService.Infrastructure.Grpc.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddGrpcClients(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddGrpc();
        services.AddGrpcReflection();

        string baseUrl = configuration["GrpcClients:UserService:Url"]
                         ?? throw new InvalidOperationException(
                             "GrpcClients:UserService:Url configuration is required");

        services.AddGrpcClient<UserService.Presentation.Grpc.Protos.UserService.UserServiceClient>(options =>
        {
            options.Address = new Uri(baseUrl);
        });

        services.AddScoped<IUserGateway, GrpcUserGateway>();

        return services;
    }
}