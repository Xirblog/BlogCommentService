using BlogCommentService.Application.Models.Users;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlogCommentService.Application.Abstractions.Integrations.Users;

public interface IUserGateway
{
    Task<User?> FindUserByIdAsync(
        Guid userId,
        CancellationToken cancellationToken);
}