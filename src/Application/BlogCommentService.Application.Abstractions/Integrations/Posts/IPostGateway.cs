using BlogCommentService.Application.Models.Posts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlogCommentService.Application.Abstractions.Integrations.Posts;

public interface IPostGateway
{
    Task<Post?> FindPostByIdAsync(
        Guid postId,
        CancellationToken cancellationToken);
}