using Microsoft.EntityFrameworkCore;
using StudentVoice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Persistance.Data.Mappings
{
    internal abstract class SurveyMapping
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Survey>()
               .Property(s => s.Id)
               .HasColumnName("Id")
               .IsRequired();

            modelBuilder.Entity<Surveys>()
               .Property(s => s.status)
               .HasColumnName("status")
               .IsRequired();

            modelBuilder.Entity<Surveys>()
                .Property(s => s.name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Surveys>()
                .Property(s => s.rating)
                .HasColumnName("rating")
                .IsRequired();

            modelBuilder.Entity<Surveys>()
                .Property(s => s.likes)
                .HasColumnName("likes")
                .IsRequired();

            modelBuilder.Entity<Surveys>()
                .Property(s => s.date)
                .HasColumnName("date")
                .IsRequired();

            modelBuilder.Entity<Surveys>()
                  .Property(s => s.ExperationDate)
                  .HasColumnName("ExpirationDate")
                  .IsRequired();

            modelBuilder.Entity<Surveys>()
                  .Property(s => s.Type)
                  .HasColumnName("Type")
                  .IsRequired();

        }
}
}
