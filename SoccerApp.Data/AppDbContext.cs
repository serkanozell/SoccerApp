using Microsoft.EntityFrameworkCore;
using SoccerApp.Data.Configurations;
using SoccerApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=DbSoccerApp;integrated security=true;");
        }
        public DbSet<AwayTeam> AwayTeams { get; set; }
        public DbSet<AwayTeamScore> AwayTeamScores { get; set; }
        public DbSet<HomeTeam> HomeTeams { get; set; }
        public DbSet<HomeTeamScore> HomeTeamScores { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Times> Times { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HomeTeamsConfiguration());
        }
    }
}
