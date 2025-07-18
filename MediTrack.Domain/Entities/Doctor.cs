using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediTrack.Domain.Common;
using MediTrack.Domain.Enums;

namespace MediTrack.Domain.Entities
{
    public class Doctor : AuditableBaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName =>
                    $"{FirstName} {MiddleName} {LastName}";

        public DoctorSpecialization Specialization { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }

        // Navigation property
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
