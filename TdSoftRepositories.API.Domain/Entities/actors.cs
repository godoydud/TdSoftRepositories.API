namespace TdSoftRepositories.API.Domain.Entities
{
    public class actors
    {
        public string id { get; set; }
        public string type { get; set; }
        public string login { get; set; }
        public string avatar_url { get; set; }

        public actors () { }

        public actors(actors actor)
        {
            id = actor.id;
            type = actor.type;
            login = actor.login;
            avatar_url = actor.avatar_url;
        }
    }
}