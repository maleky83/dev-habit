using System.Linq.Expressions;
using DevHabit.API.Entities;

namespace DevHabit.API.DTOs.Tags;

internal static class TagQureies
{
    public static Expression<Func<Tag, TagDto>> ProjectToDto()
    {
        return tag => new TagDto
        {
            Id = tag.Id,
            Name = tag.Name,
            CreatedAtUtc = tag.CreatedAtUtc,
            Description = tag.Description,
            UpdatedAtUtc = tag.UpdatedAtUtc,
        };
    }
}
