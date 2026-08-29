using BlogCommentService.Application.Models.ValueObjects;

namespace BlogCommentService.Application.Models.Users;

public sealed record User(UserId UserId, string FirstName, string LastName, Age Age);