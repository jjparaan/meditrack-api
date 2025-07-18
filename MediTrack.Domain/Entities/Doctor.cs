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
        public string FullName { get; set; }
        public DoctorSpecialization Specialization { get; set; }
        public string ContactNumber { get; set; }

        // Navigation property
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
