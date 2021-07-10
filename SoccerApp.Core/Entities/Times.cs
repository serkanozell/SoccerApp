using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp.Data.Entities
{
    public class Times
    {
        public int Id { get; set; }
        public int CurrentMinute { get; set; }
        public int Stoppage { get; set; }
    }
}
