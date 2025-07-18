using MediTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediTrack.Persistence.Contexts
{
    internal class ApplicationDbContextHelper
    {
        private readonly ModelBuilder _modelBuilder;
        public ApplicationDbContextHelper(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void ConfigureEntities()
        {
            ConfigurePatientEntity();
            ConfigureDoctorEntity();
            ConfigureAppointmentEntity();
        }

        private void ConfigurePatientEntity()
        {
            _modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NameSuffix)
                    .HasMaxLength(5);

                entity.Property(e => e.BirthDate)
                    .IsRequired();

                entity.Property(e => e.Gender)
                    .IsRequired();

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasMany(e => e.Appointments)
                    .WithOne(a => a.Patient)
                    .HasForeignKey(a => a.PatientId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }

        private void ConfigureDoctorEntity()
        {
            _modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Specialization)
                    .IsRequired();

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100);

                entity.HasMany(e => e.Appointments)
                    .WithOne(a => a.Doctor)
                    .HasForeignKey(a => a.DoctorId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }

        private void ConfigureAppointmentEntity()
        {
            _modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.PatientId)
                    .IsRequired();

                entity.Property(e => e.DoctorId)
                    .IsRequired();

                entity.Property(e => e.ScheduledDate)
                    .IsRequired();

                entity.Property(e => e.Notes)
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired();
            });
        }
    }

}
