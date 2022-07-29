using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentVoice.Domain.Entities;

namespace StudentVoice.Persistance.Data.Mappings
{
    internal abstract class UserMappings
    {
        internal static void Map(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();
            
            modelBuilder.Entity<User>()
                .Property(s => s.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(30);
            //.IsRequired();

            modelBuilder.Entity<User>()
                .Property(s => s.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(30);

            // .IsRequired();

           
            modelBuilder.Entity<User>()
                .Property(s => s.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();



            modelBuilder.Entity<User>()
                .Property(s => s.Password)
                .HasColumnName("Password")
                .HasMaxLength(50);
            //.IsRequired();

            modelBuilder.Entity<User>()
                  .Property(s => s.isAdmin)
                  .HasColumnName("isAdmin");
            //.IsRequired();

          
            
        }
    }

}
