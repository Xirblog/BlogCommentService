using BlogCommentService.Application.Models.Comments;
using System;

namespace BlogCommentService.Application.Models.Posts;

public readonly record struct PostId(Guid Value)
{
    public static CommentId Default => new(Guid.Empty);
}