using DevHabit.API.Entities;

namespace DevHabit.API.DTOs.Tags;

internal static class TagMappings
{
    public static TagDto ToDto(this Tag tag)
    {
        return new TagDto
        {
            Id = tag.Id,
            Name = tag.Name,
            CreatedAtUtc = tag.CreatedAtUtc,
            Description = tag.Description,
            UpdatedAtUtc = tag.UpdatedAtUtc,
        };
    }

    public static Tag ToEntity(this CreateTagDto dto)
    {
        return new Tag()
        {
            Id = $"t_{Guid.CreateVersion7()}",
            CreatedAtUtc = DateTime.UtcNow,
            Description = dto.Description,
            Name = dto.Name,
        };
    }

    public static void UpdateFromDto(this Tag tag, UpdateTagDto updateTagDto)
    {
        tag.Name = updateTagDto.Name;
        tag.Description = updateTagDto.Description;
        tag.UpdatedAtUtc = DateTime.UtcNow;
    }
}
