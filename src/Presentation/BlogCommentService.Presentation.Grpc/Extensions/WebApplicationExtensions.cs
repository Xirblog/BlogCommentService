using Microsoft.AspNetCore.Builder;

namespace BlogCommentService.Presentation.Grpc.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication MapGrpcServices(this WebApplication app)
    {
        // app.MapGrpcService();
        return app;
    }
}