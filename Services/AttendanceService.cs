using EventEase.Models;

namespace EventEase.Services
{
    public class AttendanceService
    {
        public List<Attendance> attendances { get; set; }
        public Action? OnAttendanceChange;

        public void TrackAttendance(int eventId, RegistrationModel user, bool isAttending) 
        {
            if (attendances == null)
            {
                attendances = new List<Attendance>();
            }

            var attendance = attendances.FirstOrDefault(a => a.EventId == eventId && a.User.Equals(user));
            if (attendance == null)
            {
                attendances.Add(new Attendance { EventId = eventId, User = user, IsAttending = isAttending });
            }
            else
            {
                attendance.IsAttending = isAttending;
            }

            OnAttendanceChange?.Invoke();
            }
        public bool IsUserAttending(int eventId, RegistrationModel user) 
        {
            bool status = false;
            if(attendances != null)
            {
                status = attendances.Any(a => a.EventId == eventId && a.User.Equals(user) && a.IsAttending);
            }           
           
            return status;
        }

        

    }
}
