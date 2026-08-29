using System;

namespace BlogCommentService.Application.Contracts.Comments.Operations;

public static class CreateComment
{
    public sealed record Request(string Content, Guid AuthorUserId, Guid PostId);

    public abstract record Response
    {
        private Response() { }

        public sealed record Success(CommentDto Comment) : Response;

        public sealed record AuthorNotFound : Response;

        public sealed record PostNotFound : Response;
    }
}