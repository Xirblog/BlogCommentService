using BlogCommentService.Application.Contracts.Comments;
using BlogCommentService.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlogCommentService.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICommentService, CommentService>();
        return services;
    }
}