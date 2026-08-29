using BlogCommentService.Application.Models.Users;
using System;

namespace BlogCommentService.Application.Models.Comments;

public sealed record Comment(
    CommentId CommentId,
    string Content,
    UserId AuthorUserId,
    DateTime CreatedAt,
    DateTime UpdatedAt);