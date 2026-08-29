using System;

namespace BlogCommentService.Application.Contracts.Comments.Operations;

public static class CreateComment
{
    public sealed record Request(Guid PostId, string Comment, Guid AuthorUserId);

    public abstract record Response
    {
        private Response() { }

        public sealed record Success : Response;
    }
}