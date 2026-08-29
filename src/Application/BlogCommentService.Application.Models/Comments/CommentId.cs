using System;

namespace BlogCommentService.Application.Models.Comments;

public readonly record struct CommentId(Guid Value)
{
    public static CommentId Default => new(Guid.Empty);
}