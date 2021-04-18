using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Frameworks.Projects.Dto
{
    public class Tag
    {
        public Tag() { }

        public Tag(string @class, string key, string value)
        {
            Class = @class;
            Key = key;
            Value = value;
        }

        public string Class { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
