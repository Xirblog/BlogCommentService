using System;

namespace BlogCommentService.Application.Models.Exceptions;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}