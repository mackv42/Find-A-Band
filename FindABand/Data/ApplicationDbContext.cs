using System;
using System.Collections.Generic;
using System.Text;
using FindABand.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FindABand.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
