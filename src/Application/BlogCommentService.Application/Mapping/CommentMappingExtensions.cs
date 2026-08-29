using BlogCommentService.Application.Contracts.Comments;
using BlogCommentService.Application.Models.Comments;

namespace BlogCommentService.Application.Mapping;

public static class CommentMappingExtensions
{
    public static CommentDto MapToDto(this Comment comment)
    {
        return new CommentDto(
            comment.CommentId.Value,
            comment.Content,
            comment.AuthorUserId.Value,
            comment.CreatedAt,
            comment.UpdatedAt);
    }
}