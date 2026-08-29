using BlogCommentService.Application.Contracts.Comments.Operations;
using System.Threading;
using System.Threading.Tasks;

namespace BlogCommentService.Application.Contracts.Comments;

public interface ICommentService
{
    Task<CreateComment.Response> CreateCommentAsync(
        CreateComment.Request request,
        CancellationToken cancellationToken);
}