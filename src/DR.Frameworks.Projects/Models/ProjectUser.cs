using DR.Packages.Mongo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Frameworks.Projects.Models
{
    public class ProjectUser : IIdentifiable
    {
        public ProjectUser() { }

        public ProjectUser(Guid id, Guid projectId, Guid userId)
        {
            Id = id;
            ProjectId = projectId;
            UserId = userId;
            Accepted = false;
            Priority = 10;
        }

        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid UserId { get; set; }
        public bool Accepted { get; set; }
        public short Priority { get; set; }
    }
}
