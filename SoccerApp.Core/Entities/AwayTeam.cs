using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp.Data.Entities
{
    public class AwayTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string MediumName { get; set; }

        public ICollection<AwayTeamScore> AwayTeamScores { get; set; }
    }
}
