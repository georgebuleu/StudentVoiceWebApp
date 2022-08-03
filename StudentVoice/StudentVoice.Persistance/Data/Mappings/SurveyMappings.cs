using Microsoft.EntityFrameworkCore;
using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Persistance.Data.Mappings
{
    internal abstract class SurveyMappings
    {
        internal static void Map(ModelBuilder modelBuilder)
        {     
            modelBuilder.Entity<Survey>()
                .Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();

            modelBuilder.Entity<Survey>()
                  .HasMany(s => s.Questions);
            
          

            modelBuilder.Entity<Survey>()
                .Property(s => s.Rating)
                .HasColumnName("Rating");
                //.IsRequired();

            modelBuilder.Entity<Survey>()
                .Property(s => s.Likes)
                .HasColumnName("Likes");
            //.IsRequired();

            modelBuilder.Entity<Survey>()
                .Property(s => s.Date)
                .HasColumnName("Date");
            //.IsRequired();

            modelBuilder.Entity<Survey>()
                  .Property(s => s.ExpirationDate)
                  .HasColumnName("ExpirationDate");
            //.IsRequired();

            modelBuilder.Entity<Survey>()
              .Property(s => s.Professor)
              .HasColumnName("Professor")
              .HasMaxLength(255);
            //.IsRequired();

            modelBuilder.Entity<Survey>()
              .Property(s => s.Class)
              .HasColumnName("Class")
              .HasMaxLength(255);
            //.IsRequired();

            modelBuilder.Entity<Survey>()
              .Property(s => s.Subject)
              .HasColumnName("Subject")
              .HasMaxLength(255);
              //.IsRequired();

        }

    }
}
