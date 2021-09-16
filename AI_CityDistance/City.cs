using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_CityDistance
{
    class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public double latitude { get; set; }//y
        public double longitude { get; set; }//x
        public List<Link> links { get; set; }

        public City(int id, string name, double latitude, double longitude)
        {
            this.id = id;
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
            links = new List<Link>();
        }
        public City(int id, string name, double latitude, double longitude, List<Link> links)
        {
            this.id = id;
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
            this.links = links;
        }
        public int getY()
        {
            return 360-Convert.ToInt32((latitude - 42.5) * 72);
        }
        public int getX()
        {
            return Convert.ToInt32((longitude - 20) * 72);
        }

        public Button createButton()
        {
            Button b = new Button();
            b.Width = 20;
            b.Height = 20;
            b.Text = name;
            b.Top = Convert.ToInt32((latitude - 42.5) * 72 ) + b.Height/2;
            b.Top = 360 - b.Top;
            b.Left = Convert.ToInt32((longitude - 20) * 72) - b.Width/2;
            return b;
        }
    }
    
}
