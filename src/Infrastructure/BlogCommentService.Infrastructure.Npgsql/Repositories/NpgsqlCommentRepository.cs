using BlogCommentService.Application.Abstractions.Persistence.Repositories;
using BlogCommentService.Application.Models.Comments;
using System.Threading;
using System.Threading.Tasks;

namespace BlogCommentService.Infrastructure.Npgsql.Repositories;

public class NpgsqlCommentRepository : ICommentRepository
{
    public Task<Comment> CreateAsync(Comment comment, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}