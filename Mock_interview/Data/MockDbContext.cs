using Microsoft.EntityFrameworkCore;
using Mock_interview.Entities;

namespace Mock_interview.Data
{
    public class MockDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Interviewer> Interviewers { get; set; }
        public virtual DbSet<InterviewCategory> InterviewCategories { get; set; }
        public virtual DbSet<Ability> Abilities { get; set; }

        public MockDbContext(
            DbContextOptions<MockDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserId)
                .WithMany();
        }
    }
}
