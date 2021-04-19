using DR.Frameworks.Projects.Dto;
using DR.Packages.Mongo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Frameworks.Projects.Models
{
    public class Project : IIdentifiable
    {
        public Project() { }

        public Project(Guid id, Guid creatorUserId, string name, string description, string iconClass, string iconColor, string iconBackgroundColor, short priority, IEnumerable<Tag> tags)
        {
            Id = id;
            CreatorUserId = creatorUserId;
            Name = name;
            Description = description;
            IconClass = iconClass;
            IconColor = iconColor;
            IconBackgroundColor = iconBackgroundColor;
            Priority = priority;
            Tags = tags;
        }

        public Guid Id { get; set; }
        public Guid CreatorUserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconClass { get; set; }
        public string IconColor { get; set; }
        public string IconBackgroundColor { get; set; }
        public short Priority { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
