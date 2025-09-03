namespace TaskManagerBackend.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateOnly? DueDate { get; set; }
        public DateTime? DueTime { get; set; }
        public string? Location { get; set; }
        public string? Notes { get; set; }

        // Parameterless constructor for EF Core
        public TaskItem() { }

        // Convenience constructors
        public TaskItem(string title, DateOnly? dueDate = null, DateTime? dueTime = null, string? location = null, string? notes = null)
        {
            Title = title;
            DueDate = dueDate;
            DueTime = dueTime;
            Location = location;
            Notes = notes;
        }
    }
}
