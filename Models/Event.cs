namespace EventEase.Models
{
    public class Event
    {        
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; } = "Online";

        public string? Description { get; set; }
    }
}
