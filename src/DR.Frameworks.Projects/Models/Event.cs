using DR.Packages.Mongo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Frameworks.Projects.Models
{
    public class Event : IIdentifiable
    {
        public Event() { }

        public Event(Guid id, string messageType, string message)
        {
            Id = id;
            ConsumedAtUtc = DateTime.UtcNow;
            MessageType = messageType;
            Message = message;
        }

        public Guid Id { get; set; }
        public DateTime ConsumedAtUtc { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
    }
}
