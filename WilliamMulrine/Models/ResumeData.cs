namespace WilliamMulrine.Models;

public record Stint(
    string? Title     = null,
    string? DateRange = null,
    List<string>? Bullets = null
);

public record ExperienceItem(
    string? Company  = null,
    string? Location = null,
    List<Stint>? Stints = null
);

public record ProjectHighlight(
    string? Name      = null,
    string? Subtitle  = null,
    List<string>? Bullets = null,
    List<ImpactStat>? Stats = null,
    string? ImpactNote = null
);

public record ImpactStat(string? Value = null, string? Label = null);

public record SkillGroup(string? Category = null, List<string>? Skills = null);

public record Education(
    string? School   = null,
    string? Location = null,
    string? Degree   = null
);

public record ResumeLink(string? Name = null, string? Link = null);

public record Resume(
    string? Name         = null,
    string? Title        = null,
    string? Location     = null,
    string? Email        = null,
    string? Availability = null,
    List<ResumeLink>? Links      = null,
    List<ExperienceItem>? Experience = null,
    List<ProjectHighlight>? Projects = null,
    List<SkillGroup>? Skills     = null,
    List<Education>? Education   = null
);
