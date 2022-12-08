using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBeReal.Shared.Domain
{
    class UserRank
    {
        public int RankNo { get; set; }
        public int UserID { get; set; }
        public int ReviewID { get; set; }
        public virtual User User { get; set; }
        public virtual Review Review { get; set; }
    }
}
