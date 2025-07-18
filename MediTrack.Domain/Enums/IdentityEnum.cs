using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediTrack.Domain.Enums
{
    public enum Gender
    {
        [Display(Name = "Prefer not to say")]
        PreferNotToSay = 0,
        Male = 1,
        Female = 2,
    }

    public enum DoctorSpecialization
    {
        // Clinical Specialties
        [Display(Name = "Internal Medicine")]
        InternalMedicine,
        Pediatrics,
        [Display(Name = "Family Medicine")]
        FamilyMedicine,
        [Display(Name = "Emergency Medicine")]
        EmergencyMedicine,
        [Display(Name = "Obstetrics and Gynecology")]
        ObstetricsAndGynecology,
        Surgery,
        Psychiatry,
        Dermatology,
        Ophthalmology,
        Otolaryngology,

        // Subspecialties
        Cardiology,
        Endocrinology,
        Gastroenterology,
        Oncology,
        Nephrology,
        Neurology,
        Pulmonology,
        Hematology,
        Rheumatology,
        [Display(Name = "Infectious Disease")]
        InfectiousDisease,

        // Diagnostic & Lab Specialties
        Radiology,
        Pathology,
        Anesthesiology,
        [Display(Name = "Nuclear Medicine")]
        NuclearMedicine,

        // Surgical Subspecialties
        Neurosurgery,
        [Display(Name = "Orthodpedic Surgery")]
        OrthopedicSurgery,
        [Display(Name = "Cardiothoracic Surgery")]
        CardiothoracicSurgery,
        [Display(Name = "Plastic Surgery")]
        PlasticSurgery,
        Urology,
        [Display(Name = "Colorectal Surgery")]
        ColorectalSurgery
    }

}
