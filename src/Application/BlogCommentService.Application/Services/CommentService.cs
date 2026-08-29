using BlogCommentService.Application.Contracts.Comments;
using BlogCommentService.Application.Contracts.Comments.Operations;
using System.Threading;
using System.Threading.Tasks;

namespace BlogCommentService.Application.Services;

public class CommentService : ICommentService
{
    public Task<CreateComment.Response> CreateCommentAsync(CreateComment.Request request, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}