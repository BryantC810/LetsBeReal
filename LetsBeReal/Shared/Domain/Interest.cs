using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBeReal.Shared.Domain
{
    class Interest
    {
        public string UserGenre { get; set; }
        public int UserNumberOfGenre { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
