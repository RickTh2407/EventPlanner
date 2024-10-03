using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using EventPlanner.Models;
using Microsoft.EntityFrameworkCore;
//https://zuydhogeschool.sharepoint.com/:p:/s/A2D1B2C2Webapplications2023-BP1/Eb9NzDbu__pBqz8f7yVatOkB_5CcXHVy0igm15kdrSMB_A?e=3mJx0L

namespace EventPlanner.Data
{
    public class EventPlannerDB : DbContext
    {
        public DbSet<Event> Event { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Participant> Participant { get; set; }
        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<Cashier> Cashier { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = @"Data Source=asusdrg4n\sqldrg4n;Initial Catalog=EventPlannerDB;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //specify Event
            modelBuilder.Entity<Event>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //specify Ticket
            modelBuilder.Entity<Ticket>()
                .Property(v => v.EventId);

            //specify Participant
            modelBuilder.Entity<Participant>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //specify Organizer
            modelBuilder.Entity<Organizer>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //specify Cashier
            modelBuilder.Entity<Cashier>()
                .Property(v => v.Name)
                .HasMaxLength(30);

            //data seed Event
            Event eventEntity = new Event()
            {
                Id = 1,
                Name = "Test Name",
                Description = "Test Description",
                Category = "Test Category",
                TimeDate = DateTime.Now,
                PricePP = 11.11,
                MaxParticipants = 22,
                ParticipantCount = 11
            };
            modelBuilder.Entity<Event>()
                .HasData(eventEntity);

            //data seed Ticket
            Ticket ticketEntity = new Ticket()
            {
                Id = 1,
                EventId = 1,
                ParticipantId = 1,
                Payed = false
            };
            modelBuilder.Entity<Ticket>()
                .HasData(ticketEntity);

            //data seed Participant
            Participant participantEntity = new Participant()
            {
                Id = 1,
                Name = "Test Participant",
                Email = "Test@Gmail.com"
            };
            modelBuilder.Entity<Participant>()
                .HasData(participantEntity);

            //data seed Organizer
            Organizer organizerEntity = new Organizer()
            {
                Id = 1,
                Name = "Test Organizer"
            };
            modelBuilder.Entity<Organizer>()
                .HasData(organizerEntity);

            //data seed Cashier
            Cashier cashierEntity = new Cashier()
            {
                Id = 1,
                Name = "Test Cashier"
            };
            modelBuilder.Entity<Cashier>()
                .HasData(cashierEntity);
        }
    }
}