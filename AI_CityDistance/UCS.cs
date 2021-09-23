using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_CityDistance
{
    class UCS
    {
        public City city { get; set; }
        public double f { get; set; }
        public double g { get; set; }
        public double h { get; set; }

        public UCS(City city)
        {
            this.city = city;
            this.g = 0;
        }

        public UCS(City city, double f, double g)
        {
            this.city = city;
            this.f = f;
            this.g = g;
        }

        public UCS(City city, double f, double g, double h)
        {
            this.city = city;
            this.f = f;
            this.g = g;
            this.h = h;
        }
    }
}
