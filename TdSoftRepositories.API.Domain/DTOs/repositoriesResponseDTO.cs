using TdSoftRepositories.API.Domain.Entities;

namespace TdSoftRepositories.API.Domain.DTOs
{
    public class repositoriesResponseDTO
    {
        public string id { get; set; }
        public int? assignable_users { get; set; }
        public string? code_of_conduct { get; set; }
        public DateTime? created_at { get; set; }
        public int? database_id { get; set; }
        public string? default_branch { get; set; }
        public bool? delete_branch_on_merge { get; set; }
        public string? description { get; set; }
        public int? disk_usage { get; set; }
        public int? forks { get; set; }
        public string? funding_links { get; set; }
        public bool? has_issues_enabled { get; set; }
        public bool? has_projects_enabled { get; set; }
        public bool? has_wiki_enabled { get; set; }
        public string? homepage_url { get; set; }
        public bool? is_archived { get; set; }
        public bool? is_blank_issues_enabled { get; set; }
        public bool? is_disabled { get; set; }
        public bool? is_empty { get; set; }
        public bool? is_fork { get; set; }
        public bool? is_in_organization { get; set; }
        public bool? is_locked { get; set; }
        public bool? is_mirror { get; set; }
        public bool? is_private { get; set; }
        public bool? is_security_policy_enabled { get; set; }
        public bool? is_template { get; set; }
        public bool? is_user_configuration_repository { get; set; }
        public int? issues { get; set; }
        public int? labels { get; set; }
        public string? languages { get; set; }
        public string? license_info { get; set; }
        public string? lock_reason { get; set; }
        public int? mentionable_users { get; set; }
        public bool? merge_commit_allowed { get; set; }
        public int? milestones { get; set; }
        public string? mirror_url { get; set; }
        public string? name { get; set; }
        public string? name_with_owner { get; set; }
        public string? open_graph_image_url { get; set; }
        public actorsDTO? repos_owner { get; set; }
        public string? parent { get; set; }
        public string? primary_language { get; set; }
        public DateTime? pushed_at { get; set; }
        public int? pull_requests { get; set; }
        public bool? rebase_merge_allowed { get; set; }
        public int? releases { get; set; }
        public string? repository_topics { get; set; }
        public bool? squash_merge_allowed { get; set; }
        public int? stargazers { get; set; }
        public int? tags { get; set; }
        public string? template_repository { get; set; }
        public DateTime? updated_at { get; set; }
        public string? url { get; set; }
        public bool? uses_custom_open_graph_image { get; set; }
        public int? vulnerability_alerts { get; set; }
        public int? watchers { get; set; }

    }
}
