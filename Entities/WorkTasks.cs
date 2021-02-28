using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Enums;

namespace Entities
{
    public class WorkTasks: IValidatableObject
    {
        public string Title { get; set; }
        public Guid ID { get; set; }
        public string Description { get; set; }
        public string AcceptanceCriteria { get; set; }
        public TaskType type { get; set; }
        public PriorityLevel priorityLevel { get; set; }
        public IEnumerable<string> Discussion { get; set; }
        public IEnumerable<string> Attachments { get; set; }
        public IEnumerable<string> Assignees { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (Title.Length > 40)
            {
                results.Add(new ValidationResult("Title cannot be more than 40 characters."));
            }
            if (Title.Length < 4)
            {
                results.Add(new ValidationResult("Title must be at least 4 characters."));
            }

            return results;
        }
    }
}