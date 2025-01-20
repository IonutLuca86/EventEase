namespace EventEase.Models
{
    public class Attendance
    {
        public int EventId { get; set; }
        public RegistrationModel User { get; set; }
        public bool IsAttending { get; set; }
    }
}
