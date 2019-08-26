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
        internal object database;

        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<BandSongSample> BandSongSamples { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<TalentByInstrument> TalentByInstruments { get; set; }
        public DbSet<TalentByGenre> TalentByGenres { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
