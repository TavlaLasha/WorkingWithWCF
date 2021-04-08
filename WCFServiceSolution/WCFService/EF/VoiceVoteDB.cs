namespace WCFService.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VoiceVoteDB : DbContext
    {
        public VoiceVoteDB()
            : base("name=VoiceVoteDB")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Singer> Singers { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Voter> Voters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Songs)
                .WithMany(e => e.Genres)
                .Map(m => m.ToTable("SongToGenre").MapLeftKey("Genre_Id").MapRightKey("Song_Id"));

            modelBuilder.Entity<Singer>()
                .HasMany(e => e.Songs)
                .WithMany(e => e.Singers)
                .Map(m => m.ToTable("SingerToSong").MapLeftKey("Singer_Id").MapRightKey("Song_Id"));

            modelBuilder.Entity<Song>()
                .HasMany(e => e.Scores)
                .WithRequired(e => e.Song)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Voter>()
                .HasMany(e => e.Scores)
                .WithRequired(e => e.Voter)
                .WillCascadeOnDelete(false);
        }
    }
}
