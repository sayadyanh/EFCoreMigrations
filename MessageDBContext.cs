using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageToText
{
    public class MessageDBContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public MessageDBContext(DbContextOptions opt) : base(opt)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
