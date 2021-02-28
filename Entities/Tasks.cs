using System;
using System.Collections.Generic;

namespace Entities
{
    public class Tasks
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AcceptanceCriteria { get; set; }
        public string Category { get; set; }
        public IEnumerable<string> Discussion { get; set; }
        public IEnumerable<string> Attachments { get; set; }
        public IEnumerable<string> Assignees { get; set; }
    }
}