using System;
using TodoManager.Domain.Common;
using TodoManager.Domain.Enums;

namespace TodoManager.Domain.Entities
{
    public class TodoItem : Entity<int>
    {
        public string Title { get; set; }

        public string Note { get; set; }

        public DateTime? Reminder { get; set; }

        public State State { get; set; }

        public PriorityLevel Priority { get; set; }

        public int ListId { get; set; }
        public TodoList List { get; set; }
    }
}
