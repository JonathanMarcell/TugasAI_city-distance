using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_CityDistance
{
    class A_Star
    {
        public A_Star(City city)
        {
            this.city = city;
            this.g = 0;
        }
        public A_Star(City city, double f,double g)
        {
            this.city = city;
            this.f = f;
            this.g = g;
        }
        public A_Star(City city, double f, double g,double h)
        {
            this.city = city;
            this.f = f;
            this.g = g;
            this.h = h;
        }
        public City city { get; set; }
        public double f { get; set; }
        public double g { get; set; }
        public double h { get; set; }
    }
}
