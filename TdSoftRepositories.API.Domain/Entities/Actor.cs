using System;
namespace TdSoftRepositories.API.Domain.Entities
{
    public class Actor
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Login { get; set; }
        public string Avatar_url { get; set; }

        public Actor () { }

        public Actor(Actor actor)
        {
            Id = actor.Id;
            Type = actor.Type;
            Login = actor.Login;
            Avatar_url = actor.Avatar_url;
        }
    }
   

 }

