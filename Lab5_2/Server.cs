using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class Server
    {
        public int ServerId { get; set; }
        public int Bandwidth { get; set; }
        public int ComputerId { get; set; }
        public virtual TSComputer Computer { get; set; }

    }
}
