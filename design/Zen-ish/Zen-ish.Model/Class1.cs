using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ConsoleApp.SqlServer
{
    public class ZenishContext : DbContext
    {
        public DbSet<UserInformation> UserInfo { get; set; }

        public DbSet<Lessons> Lesson { get; set; }

        public DbSet<Meditations> Meditation { get; set; }

        public DbSet<Wise> Wisdom { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProjectDB;Trusted_Connection=True;");
        }
    }

    public class UserInformation
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }

    public class Lessons
    {
        public int LessonId { get; set; }
        public string Lesson { get; set; }
        public bool Status { get; set; }
        public int UserID { get; set; }
    }

    public class Meditations
    {
        public int MeditationId { get; set; }
        public int Date { get; set; }
        public int Length { get; set; }
        public int Rating { get; set; }
        public int UserID { get; set; }
    }

    public class Wise
    {
        public int QuoteId { get; set; }
        public string Quote { get; set; }
        public string Author { get; set; }

        public bool Seen { get; set; }
        public int UserId { get; set; }
    }
}
