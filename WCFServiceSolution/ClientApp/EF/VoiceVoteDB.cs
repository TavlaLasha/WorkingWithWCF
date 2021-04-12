using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ClientApp.EF
{
    public partial class VoiceVoteDB : DbContext
    {
        public VoiceVoteDB()
            : base("name=VoiceVoteDB")
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Score> Score { get; set; }
        public virtual DbSet<Singer> Singer { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<Voter> Voter { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Song)
                .WithMany(e => e.Genre)
                .Map(m => m.ToTable("SongToGenre").MapLeftKey("Genre_Id").MapRightKey("Song_Id"));

            modelBuilder.Entity<Singer>()
                .HasMany(e => e.Song)
                .WithMany(e => e.Singer)
                .Map(m => m.ToTable("SingerToSong").MapLeftKey("Singer_Id").MapRightKey("Song_Id"));

            modelBuilder.Entity<Song>()
                .HasMany(e => e.Score)
                .WithRequired(e => e.Song)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Voter>()
                .HasMany(e => e.Score)
                .WithRequired(e => e.Voter)
                .WillCascadeOnDelete(false);
        }
    }
}
