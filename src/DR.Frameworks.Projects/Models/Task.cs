using DR.Frameworks.Projects.Dto;
using DR.Packages.Mongo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Frameworks.Projects.Models
{
    public class Task : IIdentifiable
    {
        public Task() { }

        public Task(
            Guid id,
            Guid? projectId,
            Guid creatorUserId,
            Guid assignedToUserId,
            string state,
            string name,
            string description,
            short priority,
            DateTime dueToUtc,
            Guid dependsOnTaskId,
            IEnumerable<Tag> tags)
        {
            Id = id;
            ProjectId = projectId;
            CreatorUserId = creatorUserId;
            AssignedToUserId = assignedToUserId;
            State = state;
            Name = name;
            Description = description;
            Priority = priority;
            DueToUtc = dueToUtc;
            DependsOnTaskId = dependsOnTaskId;
            Tags = tags;
        }

        public Guid Id { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid CreatorUserId { get; set; }
        public Guid AssignedToUserId { get; set; }
        public string State { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short Priority { get; set; }
        public DateTime DueToUtc { get; set; }
        public Guid DependsOnTaskId { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
