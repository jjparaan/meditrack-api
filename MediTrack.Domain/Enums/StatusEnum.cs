using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediTrack.Domain.Enums
{
    public enum AppointmentStatus 
    {
        [Display(Name = "Walk-In")]
        WalkIn = 0,
        Scheduled = 1,
        Completed = 2,
        Cancelled = 3,
        [Display(Name = "No Show")]
        NoShow = 4,
    }
}
