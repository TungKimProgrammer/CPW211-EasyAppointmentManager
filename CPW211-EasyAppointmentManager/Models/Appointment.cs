using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Xml.Linq;

namespace CPW211_EasyAppointmentManager.Models
{
    /// <summary>
    /// Represents a single Appointment
    /// </summary>
    public class Appointment
    {
        /// <summary> 
        /// The unique identifier for the appointment
        /// </summary>
        [Key]
        public int AppointmentId { get; set; }

        /// <summary>
        /// Date of the appointment
        /// </summary>
        [Display(Name = "Appointment Date")]
        [Required(ErrorMessage = "{0} is required.")]
        [DataType(DataType.Date)] // display Date picker
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        public TimeSlot? TimeSlot { get; set; }

        [Display(Name = "Appointment Status")]
        [Required(ErrorMessage = "{0} is required.")]
        public AppointmentStatus AppointmentStatus { get; set; }

        public Customer? Customer { get; set; }

        public Clinic? Clinic { get; set; }

        public Service? Service { get; set; }

        public Doctor? Doctor { get; set; }
    }

    public class AppointmentCreateViewModel
    {
        /// <summary>
        /// Date of the appointment
        /// </summary>
        [Display(Name = "Appointment Date")]
        [Required(ErrorMessage = "{0} is required.")]
        [DataType(DataType.Date)] // display Date picker
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public TimeSlot? TimeSlot { get; set; }

        public TimeSlot? ChosenTimeslot { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "{0} is required.")]
        public AppointmentStatus AppointmentStatus { get; set; }

        [Display(Name = "Customer")]
        public List<Customer>? AllAvailableCustomers { get; set; }

        public int ChosenCustomer { get; set; }

        [Display(Name = "Clinic")]
        public List<Clinic>? AllAvailableClinics { get; set; }

        public int ChosenClinic { get; set; }

        [Display(Name = "Service")]
        public List<Service>? AllAvailableServicesByClinicId { get; set; }
        public int ChosenService { get; set; }

        [Display(Name = "Doctor")]
        public List<Doctor>? AllAvailableDoctorsByServiceId { get; set; }

        public int ChosenDoctor { get; set; }
    }

    public enum AppointmentStatus
    {
        None,
        Confirmed,
        Cancelled,
        Missed,
        Rescheduled
    }
}
