using BlogCommentService.Application.Models.Comments;
using System.Threading;
using System.Threading.Tasks;

namespace BlogCommentService.Application.Abstractions.Persistence.Repositories;

public interface ICommentRepository
{
    Task<Comment> CreateAsync(Comment comment, CancellationToken cancellationToken);
}