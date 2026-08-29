using BlogCommentService.Application.Abstractions.Persistence.Repositories;

namespace BlogCommentService.Application.Abstractions.Persistence;

public interface IPersistenceContext
{
    ICommentRepository CommentRepository { get; }
}