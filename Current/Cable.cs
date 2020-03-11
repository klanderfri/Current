using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Current
{
    public class Cable
    {
        public int ID { get; set; }

        public double LengthInMeter { get; set; }

        public double DiameterInMeter { get; set; }

        public string Colour { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public double FromConnectionDiameterInMeter { get; set; }

        public double ToConnectionDiameterInMeter { get; set; }
    }
}
