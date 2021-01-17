using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Perf.WinFormsApp.ViewModel
{
    public class Airport
    {
            public int AIRPORTCODE { get; set; }
            public string ICAOCODE { get; set; }
            public string IATACODE { get; set; }
            public string NAME { get; set; }
            public double? ELEVATION { get; set; }
            public int? MAGNETICVARIATION { get; set; }
            public int? LATITUDE { get; set; }
            public int? LONGITUDE { get; set; }
            public string COMMENTS { get; set; }
            public List<Runway> RUNWAYS { get; set; }

    }
}
