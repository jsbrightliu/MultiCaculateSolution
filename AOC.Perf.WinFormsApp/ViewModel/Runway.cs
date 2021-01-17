using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Perf.WinFormsApp.ViewModel
{
    public class Runway
    {
        public int? MAGNETICHEADING { get; set; }
        public int? MAGNETICHEADINGDATE { get; set; }
        public string STRENGTH { get; set; }
        public double? MAXLENGTH { get; set; }
        public double? WIDTH { get; set; }
        public double? SHOULDER { get; set; }

        public string DESIGNATION { get; set; }
        public string IDENT { get; set; }
        public double? TORA { get; set; }
        public double? ASDA { get; set; }
        public double? LDA { get; set; }
        public double? TODA { get; set; }
        public int? ENTRYANGLE { get; set; }
        public double? SLOPE { get; set; }
        public int? THRESHOLDLATITUDE { get; set; }
        public int? THRESHOLDLONGITUDE { get; set; }
        public double? THRESHOLDELEVATION { get; set; }
        public double? APPROACHSLOPE { get; set; }
        public string COMMENTS { get; set; }
        public string TOCOMMENTS { get; set; }
        public string LDCOMMENTS { get; set; }
        public double? TAKEOFFSHIFT { get; set; }
        public bool GROOVEDPFCSURFACETO { get; set; }
        public bool GROOVEDPFCSURFACELD { get; set; }
        public double? GLIDESLOPE { get; set; }
        public double? IncrementGAHeight { get; set; }
        public bool GROOVEDPFCSTOPWAY { get; set; }
        public bool RUNWAYPAVEMENT { get; set; }
        public double? MinKVs { get; set; }
        public double? MaxKVs { get; set; }
        public int? APPLICABILITY { get; set; }
        public double? RUNWAYPAVEMENTCBR { get; set; }
        public double? THRUSTREDUCTIONHEIGHT { get; set; }
        public double? ACCELERATIONHEIGHT { get; set; }
        public bool CLIMBSPEEDLIMITSTATUS { get; set; }
        public double? INITIALCLIMBSPEED { get; set; }
        public string SPEEDLIMITALT { get; set; }
        public double? FINALCLIMBSPEED { get; set; }
        public List<Obstacle> OBSTACLES { get; set; }

    }
}
