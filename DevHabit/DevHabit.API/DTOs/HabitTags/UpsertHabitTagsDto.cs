namespace DevHabit.API.DTOs.HabitTags;

public sealed record UpsertHabitTagsDto
{
    public required ICollection<string> TagIds { get; init; }
}
