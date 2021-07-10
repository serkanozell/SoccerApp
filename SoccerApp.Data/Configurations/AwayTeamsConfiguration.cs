using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoccerApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp.Data.Configurations
{
    class AwayTeamsConfiguration : IEntityTypeConfiguration<AwayTeam>
    {
        public void Configure(EntityTypeBuilder<AwayTeam> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.ToTable("HomeTeam");
        }
    }
}

