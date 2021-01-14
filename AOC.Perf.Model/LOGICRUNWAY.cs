using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC.Perf.Model
{
    public partial class LOGICRUNWAY:QFU
    {
        #region Model
        private int _runwaycode;
        private int? _magneticheading;
        private int? _magneticheadingdate;
        private string _strength;
        private double? _maxlength;
        private double? _width;
        private double? _shoulder;
        private int? _airportcode;
        private int _qfurefcode;
        private string _designation;
       
        /// <summary>
        /// 
        /// </summary>
        public int RUNWAYCODE
        {
            set { _runwaycode = value; }
            get { return _runwaycode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? MAGNETICHEADING
        {
            set { _magneticheading = value; }
            get { return _magneticheading; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? MAGNETICHEADINGDATE
        {
            set { _magneticheadingdate = value; }
            get { return _magneticheadingdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STRENGTH
        {
            set { _strength = value; }
            get { return _strength; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? MAXLENGTH
        {
            set { _maxlength = value; }
            get { return _maxlength; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? WIDTH
        {
            set { _width = value; }
            get { return _width; }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? SHOULDER
        {
            set { _shoulder = value; }
            get { return _shoulder; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? AIRPORTCODE
        {
            set { _airportcode = value; }
            get { return _airportcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int QFUREFCODE
        {
            set { _qfurefcode = value; }
            get { return _qfurefcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DESIGNATION
        {
            set { _designation = value; }
            get { return _designation; }
        }

        #endregion Model
    }
}
