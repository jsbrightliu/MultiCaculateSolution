using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Perf.WinFormsApp.ViewModel
{
    public class Obstacle
    {

        public int OBSTACLECODE { get; set; }
        public int? OBSTACLENATURECODE { get; set; }
        public double? DISTANCE { get; set; }
        public double? ELEVATION { get; set; }
        public double? LATERALDISTANCE { get; set; }
        public string COMMENTS { get; set; }
        public int? QFUCODE { get; set; }

    }
}
