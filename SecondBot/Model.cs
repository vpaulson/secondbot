using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Pougan.SecondBot
{
    public class SecondBotContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=secondbot.db");
        }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        
        public List<Event> Events { get; set; }
    }

    public class Event
    {
        public int EventId { get; set; }
        public string EventType { get; set; }
        public string EventDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
