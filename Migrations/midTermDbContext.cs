using Microsoft.EntityFrameworkCore;
using midTerm.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace midTerm.Data.Migrations
{
   public class midTermDbContext
        :DbContext
    {
        public midTermDbContext(DbContextOptions<midTermDbContext> options)
        : base(options)
        {

        }
        public DbSet<Answers> Answer { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<SurveyUser> SurveyUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Option>(option =>
            {

               option.Property(p => p.Id).IsRequired();
                option.HasKey(p => p.Id);
                option.Property(p => p.Text).HasMaxLength(800).IsRequired();
                option.Property(p => p.QuestionId).IsRequired();
              
              


            });



            modelBuilder.Entity<Answers>(answer =>
            {
              
                answer.Property(p => p.Id).IsRequired();
                answer.HasKey(p => p.Id);
                answer.Property(p => p.UserId).IsRequired();
                answer.Property(p => p.OptionId).IsRequired();
                
               

            });
            modelBuilder.Entity<Question>(question =>
            {

                question.Property(p => p.Id).IsRequired();
                question.HasKey(p => p.Id);
                question.Property(p => p.Text).HasMaxLength(800).IsRequired();
                question.Property(p => p.Description).HasMaxLength(800).IsRequired();
               
                



            });
            modelBuilder.Entity<SurveyUser>(surveyuser =>
            {

                surveyuser.Property(p => p.Id).IsRequired();
                surveyuser.HasKey(p => p.Id);
               surveyuser.Property(p => p.FirstName).HasMaxLength(800).IsRequired();
                surveyuser.Property(p => p.LastName).HasMaxLength(800).IsRequired();
                surveyuser.Property(p => p.Country).HasMaxLength(800).IsRequired();






            });
        }
    }
}
