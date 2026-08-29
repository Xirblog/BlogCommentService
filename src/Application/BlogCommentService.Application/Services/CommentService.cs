using BlogCommentService.Application.Abstractions.Integrations.Posts;
using BlogCommentService.Application.Abstractions.Integrations.Users;
using BlogCommentService.Application.Abstractions.Persistence;
using BlogCommentService.Application.Contracts.Comments;
using BlogCommentService.Application.Contracts.Comments.Operations;
using BlogCommentService.Application.Mapping;
using BlogCommentService.Application.Models.Comments;
using BlogCommentService.Application.Models.Posts;
using BlogCommentService.Application.Models.Users;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlogCommentService.Application.Services;

public sealed class CommentService : ICommentService
{
    private readonly IPersistenceContext _persistenceContext;
    private readonly IUserGateway _userGateway;
    private readonly IPostGateway _postGateway;

    public CommentService(IPersistenceContext persistenceContext, IUserGateway userGateway, IPostGateway postGateway)
    {
        _persistenceContext = persistenceContext;
        _userGateway = userGateway;
        _postGateway = postGateway;
    }

    public async Task<CreateComment.Response> CreateCommentAsync(
        CreateComment.Request request,
        CancellationToken cancellationToken)
    {
        User? user = await _userGateway.FindUserByIdAsync(request.AuthorUserId, cancellationToken);
        if (user is null)
        {
            return new CreateComment.Response.AuthorNotFound();
        }

        Post? post = await _postGateway.FindPostByIdAsync(request.PostId, cancellationToken);
        if (post is null)
        {
            return new CreateComment.Response.PostNotFound();
        }

        var newComment = new Comment(
            CommentId.Default,
            request.Content,
            user.UserId,
            post.PostId,
            DateTime.UtcNow,
            DateTime.UtcNow);

        Comment comment = await _persistenceContext.CommentRepository.CreateAsync(newComment, cancellationToken);

        return new CreateComment.Response.Success(comment.MapToDto());
    }
}