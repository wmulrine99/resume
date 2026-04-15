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
                            "Architect and deliver cloud-native microservices in C#, ASP.NET Core, and Entity Framework Core targeting Azure SQL Database, Blob Storage, and Cosmos DB across multiple product lines.",
                            "Design and expose RESTful APIs consumed by cross-team platform features and external partner integrations, with full OpenAPI documentation and versioning contracts.",
                            "Drive unit and integration test coverage with xUnit and NSubstitute as a non-negotiable deliverable on every feature, not an afterthought.",
                            "Own the full SDLC — requirements, implementation, Azure DevOps CI/CD pipeline configuration, deployment, and production incident response.",
                            "Delivered an executive analytics platform on Azure SQL Database, Blob Storage, and Cosmos DB that replaced ad-hoc queries and reduced time-to-insight for stakeholders.",
                            "Process high-volume healthcare data transformations in Databricks, enabling downstream analytics teams to operate on clean, timely datasets.",
                            "Build and maintain ETL pipelines and scheduled workflows in Apache Airflow with full auditability, retry logic, and failure alerting.",
                            "Deploy and operate containerized services on AKS, managing pod scheduling, horizontal scaling, resource quotas, and CI/CD pipeline configuration.",
                            "Apply deep knowledge of X12 HIPAA EDI transaction sets to implement and validate healthcare data exchange workflows.",
                            "Leverage Claude and Cursor throughout the development cycle — from requirements decomposition to code review — compressing feature delivery without sacrificing test coverage or API contract integrity.",
                            "Apply prompt engineering to generate, validate, and iterate on complex business logic implementations, enabling faster turnaround on high-stakes healthcare data processing features.",
                        }
                    ),
                    new Stint(
                        Title:     "Software Engineer",
                        DateRange: "Aug 2022 – Aug 2023",
                        Bullets: new() { }
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
                            "Owned API versioning strategy and backward-compatibility contracts across multiple service endpoints, with Python tooling to auto-generate and publish OpenAPI documentation as part of the release pipeline.",
                            "Authored CI/CD pipeline automation and deployment monitoring scripts in Python, eliminating manual handoffs and standardizing the release process across teams.",
                            "Administered Kubernetes cluster configuration for pod scheduling, resource quotas, and network policy enforcement in a SaaS delivery environment.",
                            "Developed Python utilities for server provisioning, cross-environment data synchronization, and scheduled backup orchestration, reducing operational toil for the platform team.",
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
                            "Migrated VB.NET applications to C#, improving performance, reducing technical debt, and closing known security gaps.",
                            "Built and tuned SQL Server-backed reporting applications handling complex queries against large wildlife datasets.",
                            "Developed interactive frontend features in JavaScript and jQuery for data entry and field-level validation workflows.",
                            "Designed web forms and dashboards used to collect and manage wildlife species data and resident survey results.",
                            "Worked directly with biologists and program staff to translate evolving research requirements into working software.",
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
                    "Replaced a rigid, code-driven rules engine with a database-driven platform, decoupling business logic from application deployments.",
                    "Introduced C# generics, reflection, and dynamic dispatch to eliminate the copy-paste patterns that had accumulated across the legacy system.",
                    "Rule behavior is now fully controlled via database records, so non-engineers can configure and extend rules without code changes.",
                    "Cut the time to ship new rule implementations and gave the platform a growth path it previously lacked.",
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
            new SkillGroup("Architecture & Practices",new() { "RESTful API Design", "Microservices", "CI/CD", "SDLC Leadership", "API Versioning", "Cloud-Native Architecture", "Database-Driven Design", "Legacy Modernization" }),
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
