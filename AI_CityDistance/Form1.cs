using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AI_CityDistance
{
    public partial class TUGAS_AI_1 : Form
    {
        List<City> cities = new List<City>();
        List<Link> links = new List<Link>();
        List<Button> buttons = new List<Button>();

        City[] selectedCity= {null,null};
        public TUGAS_AI_1()
        {
            InitializeComponent();
            cities = new List<City>();
            links = new List<Link>();
            buttons = new List<Button>();
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            //load
            openFileDialog1.ShowDialog();
            if (File.Exists(openFileDialog1.FileName))
            {
                List<string> tempList = new List<string>();
                string errormessage = "error loadning file";
                try
                {
                    tempList = File.ReadAllLines(openFileDialog1.FileName).ToList();
                    richTextBox1.Text += File.ReadAllText(openFileDialog1.FileName);
                    bool AddCityMode = true; // became false when readning -Links:
                    clearAll();
                    int ctr = 0;
                    int idx = 0;
                    foreach (string item in tempList)
                    {
                        ctr++;
                        errormessage = "error reading file at Line: "+ctr;
                        string[] temp = item.Split(' ');
                        if (item == null || item == "") {
                            
                        }
                        else if (temp[0]=="-Links")
                        {
                            AddCityMode = false;
                        }
                        else if (temp[0] == "-Cities")
                        {
                            AddCityMode = true;
                        }
                        else
                        {
                            if (AddCityMode) //read cities
                            {
                                City c = new City(++idx,temp[0],Convert.ToDouble(temp[1]), Convert.ToDouble(temp[2]));
                                cities.Add(c);
                                richTextBox1.Text += "City "+ temp[0]+" added\n";
                            }
                            else //read links
                            {
                                City city1 = cities.Find(i=> i.name == temp[0]);
                                City city2 = cities.Find(i=> i.name == temp[1]);
                                Link l = new Link( Convert.ToInt32(temp[2]), city1, city2);
                                links.Add(l);
                                city1.links.Add(l);
                                city2.links.Add(l);
                                richTextBox1.Text += $"{city1.name} and {city2.name} linked\n";
                            }
                        }
                    }
                    //generate map
                    errormessage = "error generating map";
                    generateMap();
                }
                catch (Exception)
                {
                    MessageBox.Show(errormessage);
                }
            }
            else
            {
                MessageBox.Show("no file");
            }
        }
        private void clearAll()
        {
            cities = new List<City>();
            links = new List<Link>(); 
            buttons = new List<Button>();
            panelMap.Controls.Clear();
            richTextBox1.Text = "";
        }
        private void generateMap()
        {
            foreach (City item in cities)
            {  
                Button b = item.createButton();
                b.Click += buttonClicked;
                b.MouseHover += buttonHover;
                b.MouseLeave += buttonLeave;
                if (item == selectedCity[0] || item == selectedCity[1])
                {
                    b.BackColor = Color.Aqua;
                }
                panelMap.Controls.Add(b);
            }
            drawLinks();
        }
        private void drawLinks()
        {
            foreach (Link item in links)
            {
                drawLine(item.City1.getX(), item.City1.getY(), item.City2.getX(), item.City2.getY());
            }
        }
        private void drawLine(int x1, int y1, int x2, int y2)
        {
            Pen blackpen = new Pen(Color.Black, 3);
            Graphics g = panelMap.CreateGraphics();
            g.DrawLine(blackpen, x1,y1,x2,y2);
        }
        private void drawLine(City c1, City c2, Color color)
        {
            Pen blackpen = new Pen(color, 3);
            Graphics g = panelMap.CreateGraphics();
            g.DrawLine(blackpen, c1.getX(), c1.getY(), c2.getX(), c2.getY());
        }
        private void buttonRedraw_Click(object sender, EventArgs e)
        {
            panelMap.Controls.Clear();
            generateMap();
        }
        private void buttonClicked(object sender , EventArgs e)
        {
            //set city1 city2 and
            //change color
            Button b = (Button)sender;
            City temp = cities.Find(i => i.name == b.Text);

            
            if (selectedCity[0] == temp)
            {
                selectedCity[0] = null;
                b.BackColor = Control.DefaultBackColor;
            }
            else if (selectedCity[1] == temp)
            {
                selectedCity[1] = null;
                b.BackColor= Control.DefaultBackColor;
            }
            else if (selectedCity[0] == null)
            {
                selectedCity[0] = temp;
                b.BackColor = Color.Aqua;
            }
            else if (selectedCity[1] == null)
            {
                selectedCity[1] = temp;
                b.BackColor = Color.Aqua;
            }

        }
        private void buttonHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Width = 70;
            b.Height = 30;
            b.BringToFront();
        }
        private void buttonLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Width = 20;
            b.Height = 20;
            drawLinks();
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            if (radioButtonAstar.Checked)
            {
                //code
            }else if (radioButton1.Checked)
            {
                //code
            }else if (radioButton2.Checked)
            {
                //code
            }
        }

    }
}
