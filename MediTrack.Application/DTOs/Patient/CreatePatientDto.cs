using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediTrack.Domain.Enums;

namespace MediTrack.Application.DTOs.Patient
{
    public class CreatePatientDto
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }

        public string FullName =>
            $"{FirstName} {MiddleName} {LastName}" +
            (string.IsNullOrWhiteSpace(NameSuffix) ? "" : $" {NameSuffix}");

        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; } = Gender.PreferNotToSay;
        public string MobileNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string Address { get; set; }
    }
}
