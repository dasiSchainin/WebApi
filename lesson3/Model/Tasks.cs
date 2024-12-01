namespace lesson3.Model
{
    public class Tasks
    {
        public int id { get; set; }
        public int? projectId { get; set; }
        public int? userId { get; set; }
        public int? priority { get; set; }
        public DateTime? dueDate { get; set; }
        public string? Status { get; set; }
    }
}
