using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistoricalTrackingDemoLibrary.Objects
{
    public class HistoricalData 
    {
        public string Display { get; set; }
        public int SessionID { get; set; }
        public string TimeStamp { get; set; }
        public List<Coordinate> Coordinates { get; set; }
    }

    public class Coordinate
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
