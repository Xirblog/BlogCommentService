using BlogCommentService.Application.Models.Users;
using System;

namespace BlogCommentService.Application.Models.Posts;

public sealed record Post(
    PostId PostId,
    string Name,
    string Description,
    string MarkdownContent,
    UserId AuthorId,
    DateTime CreatedAt,
    DateTime UpdatedAt);