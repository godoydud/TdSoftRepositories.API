namespace TdSoftRepositories.API.Domain.Entities
{
    public class Repository
    {
        public string Id { get; set; }
        public int AssignableUsers { get; set; }
        public string CodeOfConduct { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DatabaseId { get; set; }
        public string DefaultBranch { get; set; }
        public bool DeleteBranchOnMerge { get; set; }
        public string Description { get; set; }
        public int DiskUsage { get; set; }
        public int Forks { get; set; }
        public string FundingLinks { get; set; }
        public bool HasIssuesEnabled { get; set; }
        public bool HasProjectsEnabled { get; set; }
        public bool HasWikiEnabled { get; set; }
        public string HomepageUrl { get; set; }
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
        public string Languages { get; set; }
        public string LicenseInfo { get; set; }
        public string LockReason { get; set; }
        public int MentionableUsers { get; set; }
        public bool MergeCommitAllowed { get; set; }
        public int Milestones { get; set; }
        public string MirrorUrl { get; set; }
        public string Name { get; set; }
        public string NameWithOwner { get; set; }
        public string OpenGraphImageUrl { get; set; }
        public string Owner { get; set; }
        public string Parent { get; set; }
        public string PrimaryLanguage { get; set; }
        public DateTime PushedAt { get; set; }
        public int PullRequests { get; set; }
        public bool RebaseMergeAllowed { get; set; }
        public int Releases { get; set; }
        public string RepositoryTopics { get; set; }
        public bool SquashMergeAllowed { get; set; }
        public int Stargazers { get; set; }
        public int Tags { get; set; }
        public string TemplateRepository { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Url { get; set; }
        public bool UsesCustomOpenGraphImage { get; set; }
        public int VulnerabilityAlerts { get; set; }
        public int Watchers { get; set; }

        public Repository() { }

        public Repository(Repository repository)
        {
            Id = repository.Id;
            AssignableUsers = repository.AssignableUsers;
            CodeOfConduct = repository.CodeOfConduct;
            CreatedAt = repository.CreatedAt;
            DatabaseId = repository.DatabaseId;
            DefaultBranch = repository.DefaultBranch;
            DeleteBranchOnMerge = repository.DeleteBranchOnMerge;
            Description = repository.Description;
            DiskUsage = repository.DiskUsage;
            Forks = repository.Forks;
            FundingLinks = repository.FundingLinks;
            HasIssuesEnabled = repository.HasIssuesEnabled;
            HasProjectsEnabled = repository.HasProjectsEnabled;
            HasWikiEnabled = repository.HasWikiEnabled;
            HomepageUrl = repository.HomepageUrl;
            IsArchived = repository.IsArchived;
            IsBlankIssuesEnabled = repository.IsBlankIssuesEnabled;
            IsDisabled = repository.IsDisabled;
            IsEmpty = repository.IsEmpty;
            IsFork = repository.IsFork;
            IsInOrganization = repository.IsInOrganization;
            IsLocked = repository.IsLocked;
            IsMirror = repository.IsMirror;
            IsPrivate = repository.IsPrivate;
            IsSecurityPolicyEnabled = repository.IsSecurityPolicyEnabled;
            IsTemplate = repository.IsTemplate;
            IsUserConfigurationRepository = repository.IsUserConfigurationRepository;
            Issues = repository.Issues;
            Labels = repository.Labels;
            Languages = repository.Languages;
            LicenseInfo = repository.LicenseInfo;
            LockReason = repository.LockReason;
            MentionableUsers = repository.MentionableUsers;
            MergeCommitAllowed = repository.MergeCommitAllowed;
            Milestones = repository.Milestones;
            MirrorUrl = repository.MirrorUrl;
            Name = repository.Name;
            NameWithOwner = repository.NameWithOwner;
            OpenGraphImageUrl = repository.OpenGraphImageUrl;
            Owner = repository.Owner;
            Parent = repository.Parent;
            PrimaryLanguage = repository.PrimaryLanguage;
            PushedAt = repository.PushedAt;
            PullRequests = repository.PullRequests;
            RebaseMergeAllowed = repository.RebaseMergeAllowed;
            Releases = repository.Releases;
            RepositoryTopics = repository.RepositoryTopics;
            SquashMergeAllowed = repository.SquashMergeAllowed;
            Stargazers = repository.Stargazers;
            Tags = repository.Tags;
            TemplateRepository = repository.TemplateRepository;
            UpdatedAt = repository.UpdatedAt;
            Url = repository.Url;
            UsesCustomOpenGraphImage = repository.UsesCustomOpenGraphImage;
            VulnerabilityAlerts = repository.VulnerabilityAlerts;
            Watchers = repository.Watchers;
        }
    }
}