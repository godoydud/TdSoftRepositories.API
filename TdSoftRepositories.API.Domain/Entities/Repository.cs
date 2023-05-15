namespace TdSoftRepositories.API.Domain.Entities
{
    public class Repository
    {
        public string Id { get; set; }
        public int AssignableUsers { get; set; }
        public object CodeOfConduct { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DatabaseId { get; set; }
        public string DefaultBranch { get; set; }
        public bool DeleteBranchOnMerge { get; set; }
        public string Description { get; set; }
        public int DiskUsage { get; set; }
        public int Forks { get; set; }
        public object FundingLinks { get; set; }
        public bool HasIssuesEnabled { get; set; }
        public bool HasProjectsEnabled { get; set; }
        public bool HasWikiEnabled { get; set; }
        public object HomepageUrl { get; set; }
        public bool IsArchived { get; set; }
        public bool IsBlankIssuesEnabled { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsFork { get; set; }
        public bool IsInOrganization { get; set; }
        public bool IsLocked { get; set; }
        public bool IsMirror { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsSecurityPolicyEnabled { get; set; }
        public bool IsTemplate { get; set; }
        public bool IsUserConfigurationRepository { get; set; }
        public int Issues { get; set; }
        public int Labels { get; set; }
        public object Languages { get; set; }
        public object LicenseInfo { get; set; }
        public object LockReason { get; set; }
        public int MentionableUsers { get; set; }
        public bool MergeCommitAllowed { get; set; }
        public int Milestones { get; set; }
        public object MirrorUrl { get; set; }
        public string Name { get; set; }
        public string NameWithOwner { get; set; }
        public string OpenGraphImageUrl { get; set; }
        public string Owner { get; set; }
        public object Parent { get; set; }
        public object PrimaryLanguage { get; set; }
        public DateTime PushedAt { get; set; }
        public int PullRequests { get; set; }
        public bool RebaseMergeAllowed { get; set; }
        public int Releases { get; set; }
        public string RepositoryTopics { get; set; }
        public bool SquashMergeAllowed { get; set; }
        public int Stargazers { get; set; }
        public int Tags { get; set; }
        public object TemplateRepository { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public bool UsesCustomOpenGraphImage { get; set; }
        public int VulnerabilityAlerts { get; set; }
        public int Watchers { get; set; }
    }
}

