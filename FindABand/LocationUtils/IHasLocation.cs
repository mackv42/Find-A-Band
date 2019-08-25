using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindABand.LocationUtils
{
    public interface IHasLocation
    {
        double  Longitude { get; set; }
        double Latitude { get; set; }
        string Address { get; set; }
    }
}
