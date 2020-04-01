using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var es = new ESContext();
            es.Computers.Add(new ESComputer() { Description = "EsComputer", CoolingType = "Ait x3", Price = 1500 });
                es.SaveChanges();

            var ts = new TSContext();
            ts.Computers.Add(new TSComputer() { Description = "TsComputer", CoolingType = "Ait x3", Price = 1500,
            Server=new Server() { Bandwidth = 1000 }
            });
            ts.SaveChanges();
        }
    }
}
