using BlogCommentService.Application.Abstractions.Integrations.Users;
using BlogCommentService.Application.Models.Users;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlogCommentService.Infrastructure.Grpc.Gateways;

public class GrpcUserGateway : IUserGateway
{
    public Task<User?> FindUserByIdAsync(Guid userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}