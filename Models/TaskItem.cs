namespace TaskManagerBackend.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; } = DateTime.UtcNow;
        public DateOnly DueDate { get; set; }
        public string? Location { get; set; }
        public DateTime? DueTime { get; set; }
        public string? Notes { get; set; }


        public TaskItem(int id, string title, DateOnly DueDate, string location, DateTime DueTime, string notes)
        {
            Id = id;
            Title = title;
            this.DueDate = DueDate;
            Location = location;
            this.DueTime = DueTime;
            Notes = notes;
        }
        public TaskItem(int id, string title, string description, DateOnly DueDate, DateTime DueTime, string notes)
        {
            Id = id;
            Title = title;
            this.DueDate = DueDate;
            Location = description;
            this.DueTime = DueTime;
            Notes = notes;
        }
        public TaskItem(int id, string title, DateOnly DueDate, DateTime DueTime)
        {
            Id = id;
            Title = title;
            this.DueDate = DueDate;
            this.DueTime = DueTime;

        }
    }
}