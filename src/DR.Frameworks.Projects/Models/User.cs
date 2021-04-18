using DR.Packages.Mongo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Frameworks.Projects.Models
{
    public class User : IIdentifiable
    {
        public User() { }

        public User(Guid id, string email)
        {
            Id = id;
            Email = email;
        }

        public Guid Id { get; set; }
        public string Email { get; set; }
    }
}
