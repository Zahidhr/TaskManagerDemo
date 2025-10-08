namespace TaskManager.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime DueDate { get; set; }   
        public short Priority { get; set; }
        public string Status { get; set; }
        public short CategoryId { get; set; }
    }
}
