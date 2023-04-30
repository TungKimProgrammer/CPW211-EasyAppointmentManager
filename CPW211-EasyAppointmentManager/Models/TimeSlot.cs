namespace CPW211_EasyAppointmentManager.Models
{
    public class TimeSlot
    {
        public int TimeSlotId { get; set; }

        public DateTime? TimeSlotDate { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public TimeslotStatus TimeSlotStatus { get; set;}

        public List<Doctor>? Doctors { get; set; }
    }

    public enum TimeslotStatus
    {
        Available,
        Booked
    }
}
