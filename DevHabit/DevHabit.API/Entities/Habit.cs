namespace DevHabit.API.Entities;

public sealed class Habit
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public HabitType Type { get; set; }
    public Frequency Frequency { get; set; } = new Frequency();
    public Target Target { get; set; } = new Target();
    public HabitStatus Status { get; set; }
    public bool IsArchived { get; set; }
    public DateOnly? EndDate { get; set; }
    public Milestone? Milestone { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime? UpdatedAtUtc { get; set; }
    public DateTime? LastCompletedAtUtc { get; set; }

    public List<HabitTag> HabitTags { get; set; } = null!;
    public ICollection<Tag> Tags { get; set; } = null!;

}

public enum HabitType
{
    None = 0,
    Binary = 1,
    Measurable = 2,
}

public enum HabitStatus
{
    None = 0,
    Ongoing = 1,
    Completed = 2,
}

public sealed class Frequency
{
    public FrequencyType Type { get; set; }
    public int TimesPerPeriod { get; set; }
}

public enum FrequencyType
{
    None = 0,
    Daily = 1,
    Weekly = 2,
    Monthy = 3,
}

public sealed class Target
{
    public int Value { get; set; }
    public string Unit { get; set; } = string.Empty;
}

public sealed class Milestone
{
    public int Target { get; set; }
    public int Current { get; set; }
}
