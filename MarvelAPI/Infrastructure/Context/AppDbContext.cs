using MarvelAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MarvelAPI.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Character> ().ToTable("Character");
            builder.Entity<Character> ().HasKey(a => a.Id);
            builder.Entity<Character> ().Property(a => a.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Character> ().Property(a => a.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Character> ().Property(a => a.Description).IsRequired();
            builder.Entity<Character> ().Property(a => a.Modified).IsRequired();
            //builder.Entity<Character>().Property(a => a.Thumbnails).IsRequired();
            //builder.Entity<Character>().Property(a => a.ResourceURI).IsRequired();
            //builder.Entity<Character>().Property(a => a.Comics).IsRequired();
            //builder.Entity<Character>().Property(a => a.Series).IsRequired();
            //builder.Entity<Character>().Property(a => a.Stories).IsRequired();
            //builder.Entity<Character>().Property(a => a.Events).IsRequired();
            //builder.Entity<Character>().Property(a => a.Urls).IsRequired();

            builder.Entity<Character>().HasData(
                new Character
                {
                    Id = 1009146,
                    Name = "Abomination (Emil Blonsky)",
                    Description = "Formerly known as Emil Blonsky, a spy of Soviet Yugoslavian origin working for the KGB, the Abomination gained his powers after receiving a dose of gamma radiation similar to that which transformed Bruce Banner into the incredible Hulk.",
                    Modified = new DateTime(2012, 03, 20, 12, 32, 12)
                    //Thumbnails = new Thumbnail
                    //{
                    //    Path = "http://i.annihil.us/u/prod/marvel/i/mg/9/50/4ce18691cbf04",
                    //    Extension = "jpg"
                    //}
                }
            );
        }
}
}