using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        internal Task RemoveAsync(BandSongSample song)
        {
            throw new NotImplementedException();
        }

        public DbSet<Invite> Invites { get; set; }
        public DbSet<AcceptedInvite> AcceptedInvites { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<BandMessage> BandMessages { get; set; }
        public DbSet<RoadieTestQuestion> RoadieTestQuestions { get; set; }
        public DbSet<TestAnswer> TestAnswers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
