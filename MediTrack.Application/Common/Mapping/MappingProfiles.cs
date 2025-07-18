using AutoMapper;
using MediTrack.Application.DTOs.Patients;
using MediTrack.Domain.Entities;

namespace MediTrack.Application.Common.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Patient, PatientDto>().ReverseMap();
            CreateMap<Patient, CreatePatientDto>().ReverseMap();
        }
    }
}
