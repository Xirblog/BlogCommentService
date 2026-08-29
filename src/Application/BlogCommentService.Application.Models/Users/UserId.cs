using BlogCommentService.Application.Models.Comments;
using System;

namespace BlogCommentService.Application.Models.Users;

public readonly record struct UserId(Guid Value)
{
    public static CommentId Default => new(Guid.Empty);
}