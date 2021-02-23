using Microsoft.EntityFrameworkCore;
using PortalProject.Entities.Concrete;
using PortalProject.Identity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalProject.DataAccess.Concrete.EntityFramework.Contexts
{
    public class PortalDbContext:DbContext
    {
        public PortalDbContext(DbContextOptions<PortalDbContext> options):base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseLesson> CourseLessons { get; set; }
        public DbSet<CourseAction> CourseActions { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<PollAnswer> PollAnswers { get; set; }
        public DbSet<PollVotingRecord> PollVotingRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleCategory>()
                .HasKey(x => new { x.ArticleId, x.CategoryId }); //many to many relations

            modelBuilder.Entity<UserOperationClaim>()
                .HasKey(x => new { x.UserId, x.OperationClaimId });

            modelBuilder.Entity<UserOperationClaim>()
               .HasOne(x => x.User).WithMany(x => x.UserOperationClaims).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserOperationClaim>()
               .HasOne(x => x.OperationClaim).WithMany(x => x.UserOperationClaims).HasForeignKey(x => x.OperationClaimId);

            modelBuilder.Entity<ArticleCategory>()
                .HasOne(x => x.Article).WithMany(x => x.ArticleCategories).HasForeignKey(x => x.ArticleId); //HasOne:Birebir ilişki icin kullanılır. WithMany:Bire cok ilişki için kullanılır.

            modelBuilder.Entity<ArticleCategory>()
                .HasOne(x => x.Category).WithMany(x => x.ArticleCategories).HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<ArticleMedia>()
              .HasKey(x => new { x.ArticleId, x.MediaId });

            modelBuilder.Entity<ArticleMedia>()
               .HasOne(x => x.Article).WithMany(x => x.ArticleMedias).HasForeignKey(x => x.ArticleId);

            modelBuilder.Entity<ArticleMedia>()
               .HasOne(x => x.Media).WithMany(x => x.ArticleMedias).HasForeignKey(x => x.MediaId);

            modelBuilder.Entity<CourseAction>()
                .HasOne(x => x.CourseLesson).WithMany(x => x.CourseActions).HasForeignKey(x => x.CourseLessonId);

            modelBuilder.Entity<CourseLesson>()
               .HasOne(x => x.Course).WithMany(x => x.CourseLessons).HasForeignKey(x => x.CourseId);

            modelBuilder.Entity<CourseAction>()
              .HasOne(x => x.Course).WithMany(x => x.CourseActions).HasForeignKey(x => x.CourseId);



            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PortalDbContext).Assembly);
        }
    }
}
