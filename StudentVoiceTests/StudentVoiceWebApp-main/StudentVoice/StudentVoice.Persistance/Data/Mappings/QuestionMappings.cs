using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentVoice.Domain.Entities;

namespace StudentVoice.Persistance.Data.Mappings
{
    internal class QuestionMappings
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
                .Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();

            modelBuilder.Entity<Question>()
               .Property(s => s.QuestionName)
               .HasColumnName("Question");
            //.IsRequired();

            modelBuilder.Entity<Question>()
               .Property(s => s.QuestionName)
               .HasColumnName("Answer");
            //.IsRequired();

          
        }
    }
}
