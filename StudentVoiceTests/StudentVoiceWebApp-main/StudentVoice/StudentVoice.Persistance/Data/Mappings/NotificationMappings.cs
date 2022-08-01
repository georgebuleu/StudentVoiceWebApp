using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentVoice.Domain.Entities;

namespace StudentVoice.Persistance.Data.Mappings
{
    internal class NotificationMappings
    {
        internal static void Map(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Notification>()
                    .Property(s => s.Id)
                    .HasColumnName("Id")
                    .IsRequired();


            modelBuilder.Entity<Notification>()
                    .Property(s => s.NotificationName)
                    .HasColumnName("Notification");
            //.IsRequired();

            modelBuilder.Entity<Notification>()
                    .Property(s => s.NotificationDate)
                    .HasColumnName("NotificationDate");
            //.IsRequired();

            modelBuilder.Entity<Notification>()
                .Property(s => s.isSeen)
                .HasColumnName("isSeen");
                //.IsRequired();

        }
    }
}
