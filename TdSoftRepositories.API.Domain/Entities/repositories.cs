using System.ComponentModel.DataAnnotations.Schema;
using TdSoftRepositories.API.Domain.DTOs;

namespace TdSoftRepositories.API.Domain.Entities
{
    public class repositories
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
        public string? owner { get; set; }
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

        public repositories() { }

        public repositories(repositories repository)
        {
            id = repository.id;
            assignable_users = repository.assignable_users;
            code_of_conduct = repository.code_of_conduct;
            created_at = repository.created_at;
            database_id = repository.database_id;
            default_branch = repository.default_branch;
            delete_branch_on_merge = repository.delete_branch_on_merge;
            description = repository.description;
            disk_usage = repository.disk_usage;
            forks = repository.forks;
            funding_links = repository.funding_links;
            has_issues_enabled = repository.has_issues_enabled;
            has_projects_enabled = repository.has_projects_enabled;
            has_wiki_enabled = repository.has_wiki_enabled;
            homepage_url = repository.homepage_url;
            is_archived = repository.is_archived;
            is_blank_issues_enabled = repository.is_blank_issues_enabled;
            is_disabled = repository.is_disabled;
            is_empty = repository.is_empty;
            is_fork = repository.is_fork;
            is_in_organization = repository.is_in_organization;
            is_locked = repository.is_locked;
            is_mirror = repository.is_mirror;
            is_private = repository.is_private;
            is_security_policy_enabled = repository.is_security_policy_enabled;
            is_template = repository.is_template;
            is_user_configuration_repository = repository.is_user_configuration_repository;
            issues = repository.issues;
            labels = repository.labels;
            languages = repository.languages;
            license_info = repository.license_info;
            lock_reason = repository.lock_reason;
            mentionable_users = repository.mentionable_users;
            merge_commit_allowed = repository.merge_commit_allowed;
            milestones = repository.milestones;
            mirror_url = repository.mirror_url;
            name = repository.name;
            name_with_owner = repository.name_with_owner;
            open_graph_image_url = repository.open_graph_image_url;
            owner = repository.owner;
            parent = repository.parent;
            primary_language = repository.primary_language;
            pushed_at = repository.pushed_at;
            pull_requests = repository.pull_requests;
            rebase_merge_allowed = repository.rebase_merge_allowed;
            releases = repository.releases;
            repository_topics = repository.repository_topics;
            squash_merge_allowed = repository.squash_merge_allowed;
            stargazers = repository.stargazers;
            tags = repository.tags;
            template_repository = repository.template_repository;
            updated_at = repository.updated_at;
            url = repository.url;
            uses_custom_open_graph_image = repository.uses_custom_open_graph_image;
            vulnerability_alerts = repository.vulnerability_alerts;
            watchers = repository.watchers;
        }

        public repositoriesDTO MapperToDTO(repositories repository) =>
           new repositoriesDTO
           {
               id = repository.id,
               name = repository.name
           };
    }
}