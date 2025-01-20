using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        public Dictionary<int, Event> Events { get; private set; }


        public EventService()
        {
            // Initialize with mock data
            Events = new Dictionary<int, Event>
        {
            {1, new Event { Name = "Event 1", Date = DateTime.Now, Location = "Location 1" }},
            {2, new Event { Name = "Event 2", Date = DateTime.Now, Location = "Location 2" }},
            {3, new Event { Name = "Event 3", Date = DateTime.Now, Location = "Location 3" }},
            {4, new Event { Name = "Event 4", Date = DateTime.Now, Location = "Location 4" }},
            {5, new Event { Name = "Event 5", Date = DateTime.Now, Location = "Location 5" }},
        };
        }



    }
}
