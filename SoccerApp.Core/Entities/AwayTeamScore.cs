using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp.Data.Entities
{
    public class AwayTeamScore
    {
        public int Id { get; set; }
        public int Regular { get; set; }
        public int HalfTime { get; set; }
        public int Current { get; set; }
        public int Penalties { get; set; }
        public int ExtraTime { get; set; }

        public virtual AwayTeam AwayTeam { get; set; }
    }
}
