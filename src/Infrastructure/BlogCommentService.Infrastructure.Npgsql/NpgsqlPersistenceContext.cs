using BlogCommentService.Application.Abstractions.Persistence;
using BlogCommentService.Application.Abstractions.Persistence.Repositories;

namespace BlogCommentService.Infrastructure.Npgsql;

public class NpgsqlPersistenceContext : IPersistenceContext
{
    public NpgsqlPersistenceContext(ICommentRepository commentRepository)
    {
        CommentRepository = commentRepository;
    }

    public ICommentRepository CommentRepository { get; }
}