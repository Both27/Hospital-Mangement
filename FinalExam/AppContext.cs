using FinalExam;
using FinalExam.Object;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class AppContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<UserAuth> auths { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<RoomType> roomsType { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<DocSpecialty> docSpecialties { get; set; }
        public DbSet<Medicine> medicines { get; set; }
        public DbSet<MedCategory> medCategories { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<BillingItem> BillingItems { get; set; }
        public DbSet<Patient> Patients { get; set; }

        private string connectionString = "Data Source=SLEEPYBOBBY\\SQLBOBBY22;Initial Catalog=FinalExamHospitalManagement;Integrated Security=True;Trust Server Certificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<User>()
                .HasOne(u => u.UserAuth)
                .WithOne(ua => ua.User)
                .HasForeignKey<UserAuth>(ua => ua.UserId);


            modelBuilder.Entity<Room>()
                .HasOne(r => r.RoomType)
                .WithMany(rt => rt.Rooms)
                .HasForeignKey(r => r.RoomTypeId);

            modelBuilder.Entity<Doctor>()
               .HasOne(d => d.DocSpecialtys)
               .WithMany(ds => ds.Doctors)
               .HasForeignKey(d => d.SpecialtyId);

            modelBuilder.Entity<Medicine>()
                .HasOne(m => m.MedCategorys)
                .WithMany(mc => mc.Medicines)
                .HasForeignKey(m => m.MedCategoryId);

            modelBuilder.Entity<BillingItem>()
                .HasOne(bi => bi.Billings)
                .WithMany(b => b.BillingItems)
                .HasForeignKey(bi => bi.BillingId);

            modelBuilder.Entity<BillingItem>()
                .HasOne(bi => bi.Medicines)
                .WithMany(m => m.BillingItems)
                .HasForeignKey(bi => bi.MedicineId);

            modelBuilder.Entity<Patient>()
               .HasOne(p => p.Rooms)
               .WithMany(r => r.Patients)
               .HasForeignKey(p => p.RoomId);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Doctors)
                .WithMany(d => d.Patients)
                .HasForeignKey(p => p.DoctorId);

            modelBuilder.Entity<Billing>()
                .HasOne(b => b.Patients)
                .WithMany(p => p.Billings)
                .HasForeignKey(b => b.PatientId);

            modelBuilder.Entity<Billing>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bills)
                .HasForeignKey(b => b.UserId);
        }
    }
}
