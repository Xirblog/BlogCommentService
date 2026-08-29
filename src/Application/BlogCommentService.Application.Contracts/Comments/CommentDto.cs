using System;

namespace BlogCommentService.Application.Contracts.Comments;

public sealed record CommentDto(
    Guid CommentId,
    string Content,
    Guid AuthorUserId,
    DateTime CreatedAt,
    DateTime UpdatedAt);