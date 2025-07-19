using AutoMapper;
using MediTrack.Application.DTOs.Patients;
using MediTrack.Application.Interfaces.Repositories;
using MediTrack.Domain.Entities;
using MediTrack.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace MediTrack.Infrastructure.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PatientRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Guid> CreateAysnc(CreatePatientDto dto)
        {
            Patient patient = _mapper.Map<Patient>(dto);
            patient.Id = Guid.NewGuid();
            patient.CreatedOn = DateTime.Now;

            await _context.Patients.AddAsync(patient);
            await _context.SaveChangesAsync();

            return patient.Id;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            Patient patient = await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return false;
            }

            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<PatientDto>> GetAllAsync()
        {
            List<Patient> patients = await _context.Patients.ToListAsync();
            return _mapper.Map<List<PatientDto>>(patients);
        }

        public async Task<PatientDto> GetByIdAsync(Guid id)
        {
            Patient patient = await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return new PatientDto();
            }

            return _mapper.Map<PatientDto>(patient);
        }

        public async Task<bool> UpdateAsync(Guid id, CreatePatientDto dto)
        {
            if (dto == null)
            {
                return false;
            }

            var patient = await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return false;
            }

            patient.ModifiedOn = DateTime.Now;

            _mapper.Map(dto, patient);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
