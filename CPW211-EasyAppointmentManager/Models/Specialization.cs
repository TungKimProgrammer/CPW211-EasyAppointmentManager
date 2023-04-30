using System.ComponentModel.DataAnnotations;

namespace CPW211_EasyAppointmentManager.Models
{
    /// <summary>
    /// Represents a single Specialization
    /// </summary>
    public class Specialization
    {
        /// <summary>
        /// The unique identifier for the Specialization
        /// </summary>
        [Key]
        public int SpecializationId { get; set; }

        /// <summary>
        /// The name of the Specialization
        /// </summary>
        [Display(Name = "Specialization")]
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// The code of the Specialization
        /// </summary>
        [Display(Name = "Specialization Code")]
        [StringLength(100)]
        public string? Code { get; set; }

        /// <summary>
        /// The description of the Specialization
        /// </summary>
        public string? Description { get; set; }
    }
}
