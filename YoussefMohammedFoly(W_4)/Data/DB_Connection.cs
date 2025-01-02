﻿using Microsoft.EntityFrameworkCore;
using YoussefMohammedFoly_W_4_.Models;

namespace YoussefMohammedFoly_W_4_.Data
{
    public class DB_Connection :DbContext
    {
        public DB_Connection(DbContextOptions<DB_Connection> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

    }
}
