
using Microsoft.EntityFrameworkCore;
using StudentVoice.Domain.Entities;
using System.Collections.Generic;
using StudentVoice.Persistance.Data.Mappings;

namespace StudentVoice.Persistance.Data
{
    public class StudentVoiceDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Survey> Surveys { get; set; }
       

        public StudentVoiceDbContext(DbContextOptions<StudentVoiceDbContext> options) :
        base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(local)\SQLEXPRESS;Database=StudentVoice;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SurveyMappings.Map(modelBuilder);
            UserMappings.Map(modelBuilder);
            NotificationMappings.Map(modelBuilder);
            
           
            SeedDatabase(modelBuilder);
        }

        private static void SeedDatabase(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("SurveyUser")
                .HasData(
                new { UsersId = 1, SurveysId = 1 },
                new { UsersId = 1, SurveysId = 2 },
                new { UsersId = 1, SurveysId = 3 },
                new { UsersId = 2, SurveysId = 1 },
                new { UsersId = 2, SurveysId = 3 },
                new { UsersId = 3, SurveysId = 2 },
                new { UsersId = 3, SurveysId = 3 },
                new { UsersId = 4, SurveysId = 2 },
                new { UsersId = 4, SurveysId = 1 }


                ) ;
            */

            modelBuilder.Entity<Survey>().HasData(new List<Survey>()
            {
                new Survey()
                {
                   
                    Id = 1,
                    Date =System.DateTime.Today,
                    Rating = 5,
                    Likes = 34,
                    ExpirationDate = System.DateTime.Today,
                    Professor="Alex",
                    Class="I",
                    Subject="Mate"
                },

                new Survey()
                {
                    Id=2,
                    Date=System.DateTime.Today,
                    Rating=4,
                    Likes=23,
                    ExpirationDate=System.DateTime.Today,
                    Professor="Cosmin",
                    Class="II",
                    Subject="Mate"
                },
                new Survey()
                {
                    Id=3,
                    Date=System.DateTime.Today,
                    Rating=4,
                    Likes=23,
                    ExpirationDate=System.DateTime.Today,
                    Professor="Cosmin",
                    Class="II",
                    Subject="Info"
                }

            }); ;

            modelBuilder.Entity<Question>().HasData(new List<Question>()
            {
                new Question() {
                    Id = 1,
                    QuestionName = "Please rate this class.",
                    Answer = "5",
                    Type = "Rating"
                    },
                 new Question() {
                    Id = 2,
                    QuestionName = "What is something you liked about this class?",
                    Answer= "I really liked the fact that this class focused more on the quality of code than the quantity",
                    Type="Text"
                    },
                 new Question() {
                    Id=3,
                    QuestionName = "What is something you liked about this class?",
                    Answer = "I really liked the fact that this class focused more on the quality of code than the quantity.",
                    Type="Text"
                    },
                 new Question() {
                    Id=4,
                    QuestionName = "What is something that we can improve about this class?",
                    Answer = "I don't feel like there are improvements needed.",
                    Type="Text"
                    }

            }) ;
            modelBuilder.Entity<Notification>().HasData(new List<Notification>() {

                new Notification() {
                Id = 1,
                NotificationName = "Question needs to be approved",
                NotificationDate = System.DateTime.Now,
                isSeen = false,
                },

                new Notification() {
                Id = 2,
                NotificationName = "A student answered a question",
                NotificationDate = System.DateTime.Now,
                isSeen = true
                },
                new Notification() {
                Id = 3,
                NotificationName = "Your qustion was aproved",
                NotificationDate = System.DateTime.Now,
                isSeen = true
                }
            }); 
        }
        }
    }
    
