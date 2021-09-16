using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_CityDistance
{
    class Link
    {
        public int weight { get; set; }
        public City City1 { get; set; }
        public City City2 { get; set; }

        public Link(int weight, City city1, City city2)
        {
            this.weight = weight;
            City1 = city1;
            City2 = city2;
        }
    }
}
