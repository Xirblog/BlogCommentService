using BlogCommentService.Application.Models.Exceptions;

namespace BlogCommentService.Application.Models.ValueObjects;

public readonly record struct Age
{
    public Age(long value)
    {
        if (value <= 0)
        {
            throw new InvalidAgeException("Age must be greater than zero");
        }

        Value = value;
    }

    public long Value { get; }
}