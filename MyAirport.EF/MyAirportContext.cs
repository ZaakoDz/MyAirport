﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;



namespace ZW.MyAirport.EF
{
    public class MyAirportContext : DbContext //permet de réferencer la base de donnée qui sera créée lors de l'update (elle contiendra Flights et Luggages)
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Luggage> Luggages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=MyAirport;Integrated Security=True");
        }

    }
}
