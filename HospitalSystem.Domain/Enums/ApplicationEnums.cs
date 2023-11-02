using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Domain.Enums
{
    /// <summary>
    /// User Enums
    /// </summary>
    public enum Gender
    {
        Male, Female, Other
    }

    public enum CofirmationDoctor
    {
        Confirmed,
        Pending,
        Refused,
        Register


    }


    public enum RegisteredRole
    {
        None,
        Doctor,
        Nurse,
        Receiptionist,
        Employee,
        Patient

    }
    public enum Specialist
    {
        None,
        Emergency,
        Pediatrics,
        Surgery,
        InternalMedicine,
        ObstetricsGynecology
    }
    /// <summary>
    /// Visits Enums
    /// </summary>
    public enum VisitStatus
    {
        Scheduled,
        InProgress,
        Completed,
        Cancelled,
        Rescheduled,
        Postponed,
        NoShow,
        Arrived,
        Unknown
    }
    public enum IsDeleted
    {
        NotDeleted,
        Deleted
    }

    public enum VisitType
    {
        FirstVisit,

        FollowUpVisit,

        RegularCheckup,

        EmergencyVisit,

        // Add more visit types as needed
    }
    /// <summary>
    /// Appointment Enums
    /// </summary>
    public enum AppointmentConfirmation
    {
        [Display(Name = "Pending Confirmation")]
        PendingConfirmation = 0,

        [Display(Name = "Confirmed by Doctor")]
        ConfirmedByDoctor = 1,

        [Display(Name = "Cancelled by Doctor")]
        CancelledByDoctor = 2,

        [Display(Name = "Cancelled by Patient")]
        CancelledByPatient = 3,
    }
    /// <summary>
    /// Shifts Enums
    /// </summary>
    public enum Shifts
    {
        MoriningShiftfrom8Amto5pm,
        NightShiftfrom5pmto8Am,
        HasNoShifts
    }
    public enum ShiftStatus
    {
        [Display(Name = " is Available")]
        Available = 1,

        [Display(Name = " is DoctorLeaveWork")]
        DoctorLeaveWork = 2,

        [Display(Name = " is FinsiedShift")]
        FinsiedShift = 3,
        [Display(Name = " is NotAvilable")]

        NotAvailable = 4

    }
}
