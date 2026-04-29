using WilliamMulrine.Models;

namespace WilliamMulrine;

/// <summary>
/// Edit this file to customise the resume.
/// Every piece of visible text on the page comes from here.
/// </summary>
public static class ResumeContent
{
    public static readonly Resume Data = new(

        Name:         "William Mulrine",
        Title:        "Senior Software Engineer",
        Location:     "Holly Springs, NC",
        Email:        "mulrine@gmail.com",
        Availability: "",

        Links: new()
        {
            new ResumeLink("GitHub", "https://github.com/wmulrine99/resume"),
            new ResumeLink("LinkedIn", "https://www.linkedin.com/in/billy-mulrine-000726a0/"),
        },

        Experience: new()
        {
            new ExperienceItem(
                Company:  "R1 RCM",
                Location: "Remote",
                Stints: new()
                {
                    new Stint(
                        Title:     "Senior Software Engineer",
                        DateRange: "Apr 2024 – Present",
                        Bullets: new()
                        {
                            "Built cloud-native services in C#, ASP.NET Core, and Entity Framework Core against Azure SQL Database, Blob Storage, and Cosmos DB across multiple product lines.",
                            "Built analytics platform on Azure SQL Database, Blob Storage, and Cosmos DB that replaced a patchwork of ad-hoc queries stakeholders had been running directly against prod.",
                            "Own the full SDLC  requirements, implementation, Azure DevOps CI/CD, deployment, and production incident response.",
                            "Use Claude Code throughout the development cycle, from breaking down requirements to code review, which lets me ship faster without cutting corners on test coverage or API contracts.",
                            "Leverage prompt engineering to work through complex healthcare data processing logic useful for getting a second opinion on high-stakes transformations before they go out.",
                        }
                    ),
                    new Stint(
                        Title:     "Software Engineer",
                        DateRange: "Aug 2022 – Aug 2023",
                        Bullets: new()
                        {
                            "Built cloud-native services in C#, ASP.NET Core, and Entity Framework Core against Azure SQL Database, Blob Storage, and Cosmos DB across multiple product lines.",
                            "Designed and shipped RESTful APIs used by other teams and external partner integrations, with OpenAPI documentation and versioning.",
                            "Treated unit and integration test coverage with xUnit and NSubstitute as part of the work, not something to circle back on after the fact.",
                            "Ran high-volume healthcare data transformations in Databricks so analytics teams had clean, timely data to work with.",
                            "Built and maintained ETL pipelines and scheduled workflows in Apache Airflow, including retry logic and failure alerting.",
                            "Deployed and operated containerized services on AKS  pod scheduling, horizontal scaling, resource quotas, and CI/CD pipeline setup.",
                            "Worked extensively with X12 HIPAA EDI transaction sets to implement and validate healthcare data exchange workflows.",
                        }
                    ),
                }
            ),
            new ExperienceItem(
                Company:  "SAS Institute",
                Location: "Cary, NC",
                Stints: new()
                {
                    new Stint(
                        Title:     "Senior Associate Software Engineer",
                        DateRange: "Aug 2023 – Apr 2024",
                        Bullets: new()
                        {
                            "Owned API versioning and backward-compatibility contracts across multiple service endpoints, with Python tooling to generate and publish OpenAPI docs as part of the release pipeline.",
                            "Wrote CI/CD pipeline automation and deployment monitoring scripts in Python that removed several manual handoffs from the release process.",
                            "Managed Kubernetes cluster configuration for pod scheduling, resource quotas, and network policy in a SaaS delivery environment.",
                            "Built Python utilities for server provisioning, cross-environment data sync, and scheduled backup orchestration that freed the platform team from a lot of recurring manual work.",
                        }
                    ),
                }
            ),
            new ExperienceItem(
                Company:  "NC Wildlife Resources Commission",
                Location: "Raleigh, NC",
                Stints: new()
                {
                    new Stint(
                        Title:     "Software Engineer",
                        DateRange: "May 2016 – Aug 2022",
                        Bullets: new()
                        {
                            "Migrated VB.NET applications to C#, picking up performance improvements and closing a handful of known security issues along the way.",
                            "Built and tuned SQL Server reporting applications that ran complex queries against large wildlife datasets.",
                            "Added frontend features in JavaScript and jQuery for data entry and validation across several internal tools.",
                            "Designed web forms and dashboards for collecting and managing wildlife species data and resident survey results.",
                            "Worked directly with biologists and program staff to figure out what they actually needed and turn it into working software.",
                        }
                    ),
                }
            ),
        },

        Projects: new()
        {
            new ProjectHighlight(
                Name:     "R1 Edit",
                Subtitle: "Rules Engine Re-Architecture · R1 RCM",
                Bullets: new()
                {
                    "Replaced a rigid, code-driven rules engine with a database-driven platform so that business logic changes don't require application deployments.",
                    "Used C# generics, reflection, and dynamic dispatch to get rid of the copy-paste patterns that had built up across the legacy system.",
                    "Rule behavior is now controlled entirely through database records  non-engineers can configure and extend rules without touching code.",
                    "Changing rule configurations went from a development cycle to a database change.",
                },
                Stats: new()
                {
                    new ImpactStat("21M", "Claims Processed in 2025"),
                    new ImpactStat("14M", "Claims Corrected by R1 Edit"),
                    new ImpactStat("67%",  "Data Quality Fix Rate"),
                }
            ),
        },

        Skills: new()
        {
            new SkillGroup("Languages",               new() { "C#", "Python", "SQL", "JavaScript", "TypeScript", "VB.NET" }),
            new SkillGroup("Frameworks & Libraries",  new() { "ASP.NET Core", "Entity Framework Core", "Blazor", "xUnit", "NSubstitute", "jQuery" }),
            new SkillGroup("Cloud & Infrastructure",  new() { "Microsoft Azure", "Azure Kubernetes Service (AKS)", "Azure SQL Database", "Blob Storage", "Cosmos DB", "Docker" }),
            new SkillGroup("Data & Analytics",        new() { "Databricks", "Apache Airflow", "SQL Server", "ETL Pipelines", "SSRS" }),
            new SkillGroup("Architecture & Practices",new() { "RESTful API Design", "CI/CD", "SDLC Leadership", "API Versioning", "Cloud-Native Architecture", "Database-Driven Design", "Legacy Modernization" }),
            new SkillGroup("Healthcare & Compliance", new() { "X12 HIPAA EDI", "HIPAA Compliance", "Healthcare Data Processing", "Claims Processing" }),
            new SkillGroup("AI & Prompt Engineering", new() { "Claude", "Cursor", "GitHub Copilot", "Prompt Engineering", "AI-Assisted Development", "LLM Workflows" }),
            new SkillGroup("Tools & Platforms",       new() { "Git", "Azure DevOps", "Kubernetes", "OpenAPI / Swagger", "Visual Studio", "VS Code" }),
        },

        Education: new()
        {
            new Education(
                School:   "Wake Technical Community College",
                Location: "Raleigh, NC",
                Degree:   "AAS in Computer Programming"
            ),
        }
    );
}
