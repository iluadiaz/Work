using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DevOpsTask;

namespace DevOpsTask.Models
{
    public partial class BandcDbContext : DbContext
    {
        public BandcDbContext()
        {
        }

        public BandcDbContext(DbContextOptions<BandcDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcceptedApp> AcceptedApps { get; set; } = null!;
        public virtual DbSet<AppointedApp> AppointedApps { get; set; } = null!;
        public virtual DbSet<BoardMember> BoardMembers { get; set; } = null!;
        public virtual DbSet<BoardMember1> BoardMembers1 { get; set; } = null!;
        public virtual DbSet<BoardMembersFulldatum> BoardMembersFulldata { get; set; } = null!;
        public virtual DbSet<ExpiredApplication> ExpiredApplications { get; set; } = null!;
        public virtual DbSet<MBoardsandCommission> MBoardsandCommissions { get; set; } = null!;
        public virtual DbSet<NoWardPerson> NoWardPeople { get; set; } = null!;
        public virtual DbSet<PeopleWithNoApplication> PeopleWithNoApplications { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<PersonApplication> PersonApplications { get; set; } = null!;
        public virtual DbSet<PersonApplicationsDetail> PersonApplicationsDetails { get; set; } = null!;
        public virtual DbSet<PersonFullName> PersonFullNames { get; set; } = null!;
        public virtual DbSet<ReportSummary> ReportSummaries { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<SubmittedApplication> SubmittedApplications { get; set; } = null!;
        public virtual DbSet<UsersInRole> UsersInRoles { get; set; } = null!;
        public virtual DbSet<VoluntarySurvey> VoluntarySurveys { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=DbConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcceptedApp>(entity =>
            {
                entity.ToView("Accepted_Apps");
            });

            modelBuilder.Entity<AppointedApp>(entity =>
            {
                entity.ToView("Appointed_Apps");
            });

            modelBuilder.Entity<BoardMember>(entity =>
            {
                entity.ToView("Board_Members");
            });

            modelBuilder.Entity<BoardMembersFulldatum>(entity =>
            {
                entity.ToView("BoardMembers_Fulldata");
            });

            modelBuilder.Entity<ExpiredApplication>(entity =>
            {
                entity.ToView("Expired_Applications");
            });

            modelBuilder.Entity<NoWardPerson>(entity =>
            {
                entity.ToView("NoWardPeople");

                entity.Property(e => e.PersonKey).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PeopleWithNoApplication>(entity =>
            {
                entity.ToView("People_with_no_Applications");

                entity.Property(e => e.PersonKey).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PersonApplicationsDetail>(entity =>
            {
                entity.ToView("Person_ApplicationsDetails");
            });

            modelBuilder.Entity<PersonFullName>(entity =>
            {
                entity.ToView("Person_FullName");

                entity.Property(e => e.PersonKey).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReportSummary>(entity =>
            {
                entity.ToView("Report_Summary");
            });

            modelBuilder.Entity<SubmittedApplication>(entity =>
            {
                entity.ToView("Submitted_Applications");
            });

            modelBuilder.Entity<UsersInRole>(entity =>
            {
                entity.HasKey(e => new { e.PersonKey, e.RoleId })
                    .HasName("PK__UsersInR__FD5A21675AEE82B9");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UsersInRoleRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
