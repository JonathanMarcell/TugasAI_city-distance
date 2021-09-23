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
        List<City> path = new List<City>();
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
                richTextBox1.Text += $"\n===================================\n\n";
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
            panelMap.Invalidate();
            richTextBox1.Text = "";
            path = new List<City>();
            selectedCity[0] = null;
            labelGoalCity.Text = "-";
            labelStartCity.Text = "-";
            selectedCity[1] = null;
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
            for (int i = 0; i < path.Count - 1; i++)
            {
                drawLine(path[i], path[i + 1], Color.Red);
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
                labelStartCity.Text = "-";
            }
            else if (selectedCity[1] == temp)
            {
                selectedCity[1] = null;
                b.BackColor= Control.DefaultBackColor;
                labelGoalCity.Text = "-";
            }
            else if (selectedCity[0] == null)
            {
                selectedCity[0] = temp;
                b.BackColor = Color.Aqua;
                labelStartCity.Text = selectedCity[0].name;
            }
            else if (selectedCity[1] == null)
            {
                selectedCity[1] = temp;
                b.BackColor = Color.Aqua;
                labelGoalCity.Text = selectedCity[1].name;
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
            if (selectedCity[0]==null ||selectedCity[1]==null) { return; }
            if (radioButtonAstar.Checked)
            {
                /////////////////////////////////////////////////////////////
                //create open and close list
                List<A_Star> openlist = new List<A_Star>();
                List<City> closedlist = new List<City>();

                
                A_Star start = new A_Star(selectedCity[0]);
                //add the start node
                openlist.Add(start);

                City current = null;
                while (openlist != null)
                {
                    // look for the lowest F cost, F = g + H  ,
                    // g = distance between the current node and the start node
                    // H = heuristic cost Using manhattan distance
                    if (openlist.Count<1)  
                    {
                        MessageBox.Show("Gagal");
                        break;   
                    }
                    A_Star visitedCity = openlist[0];
                    if (visitedCity.city==selectedCity[1]) // sampai ditujuan
                    {
                        closedlist.Add(visitedCity.city);
                        path = closedlist;
                        openlist = null;
                        richTextBox1.Text +="\n ========= \n";
                        richTextBox1.Text += "Rute by A* :\n";
                        foreach (City rute in closedlist)
                        {
                            richTextBox1.Text += $"{rute.name} , ";
                        }
                        panelMap.Invalidate();
                        generateMap();
                        for (int i = 0; i < closedlist.Count-1; i++)
                        {
                            drawLine(closedlist[i], closedlist[i+1], Color.Red);
                        }
                    }
                    else
                    {
                        List<A_Star> BranchList = new List<A_Star>();
                        // masuk ke tiap visited
                        foreach (Link link in visitedCity.city.links)
                        {
                            //masuk ke tiap anaknya, cek juga mana yang asal/parent dan target/current
                            current = link.City1;
                            if (current == visitedCity.city) { current = link.City2; }
                            //cari city f cost terkecil
                            double g = link.weight+visitedCity.g;
                            double h = HeuristicDistance(current, selectedCity[1]);
                            A_Star temp= new A_Star(current, g + h, g, h);
                            if (!closedlist.Contains(current))// tidak mengambil yang sudah dilewati
                            {
                                BranchList.Add(temp);
                            }
                        }
                        //sort berdasar f cost
                        BranchList = BranchList.OrderBy(branch => branch.f).ToList();
                        //masukkan branch dengan f cost terkecil ke openlist
                        if (BranchList.Count>0)
                        {
                            openlist.Add(BranchList[0]);
                        }
                        //pindah ke closed karena sudah dilewati
                        openlist.Remove(visitedCity);
                        closedlist.Add(visitedCity.city);
                        openlist = openlist.OrderBy(branch => branch.f).ToList();
                    }
                }
            }
            else if (rbUCS.Checked)
            {
                //code
                List<UCS> openlist = new List<UCS>();
                List<City> closedlist = new List<City>();

                UCS startNode = new UCS(selectedCity[0]);
                openlist.Add(startNode);
                City currNode = null;

                while(openlist != null)
                {
                    if (openlist.Count<1)
                    {
                        MessageBox.Show("Belum memilih Node Awal!");
                        break;
                    }

                    UCS visitedNode = openlist[0];
                    if (visitedNode.city == selectedCity[1])
                    {
                        closedlist.Add(visitedNode.city);
                        path = closedlist;
                        openlist = null;
                        richTextBox1.Text += "\n ========= \n";
                        richTextBox1.Text += "Rute by UCS :\n";
                        foreach (City rute in closedlist)
                        {
                            richTextBox1.Text += $"{rute.name} , ";
                        }
                        panelMap.Invalidate();
                        generateMap();
                        for (int i = 0; i < closedlist.Count - 1; i++)
                        {
                            drawLine(closedlist[i], closedlist[i + 1], Color.Red);
                        }
                    }
                    else
                    {
                        List<UCS> childNode = new List<UCS>();
                        foreach (Link link in visitedNode.city.links)
                        {
                            //memasukkan child dari startNode 
                            currNode = link.City1;
                            if (currNode == visitedNode.city) { currNode = link.City2; }
                            //MessageBox.Show(currNode.name.ToString());
                            double g = link.weight + visitedNode.g;
                            double h = UCSdistance(currNode, selectedCity[1]);
                            //MessageBox.Show(h.ToString());
                            UCS final = new UCS(currNode, g + h, g, h);
                            if (!closedlist.Contains(currNode))
                            {
                                childNode.Add(final);
                            }
                        }
                        childNode = childNode.OrderBy(branch => branch.f).ToList();
                        if (childNode.Count > 0)
                        {
                            openlist.Add(childNode[0]);
                        }
                        openlist.Remove(visitedNode);
                        closedlist.Add(visitedNode.city);
                        openlist = openlist.OrderBy(branch => branch.f).ToList();
                    }
                }
            }
            else if (btnBfs.Checked)
            {
                //code
                bfs(selectedCity[0], selectedCity[1]);
            }
        }

        bool useXY_for_HeuristicDistance = true;
        private double HeuristicDistance(City city1 , City city2)
        {
            if (useXY_for_HeuristicDistance)
            {
                // calc from latitude longitude resultant
                double deltaY = Math.Abs(city1.getY() - city2.getY());
                double deltaX = Math.Abs(city1.getX() - city2.getX());
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
            else
            {
                // calc from latitude longitude resultant
                double deltaY = Math.Abs(city1.latitude - city2.latitude);
                double deltaX = Math.Abs(city1.longitude - city2.longitude);
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
            //useful fact: sebenarnya ga perlu di sqrt juga hasilnya sama
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        void bfs(City start, City goal)
        {
            List<City> bfstrav = new List<City>();

            Queue<City> queue = new Queue<City>();
            City cur = start;
            cur.isVisited = true;
            queue.Enqueue(cur);

            IDictionary<City, City> parent = new Dictionary<City, City>();

            foreach (City city in cities)
            {
                parent[city] = null;
            }

            while (queue.Count != 0)
            {
                City u = queue.Dequeue();
                bfstrav.Add(u);

                for (int i = 0; i < u.links.Count; i++)
                {
                    if (!u.links[i].City2.isVisited)
                    {
                        u.links[i].City2.isVisited = true;
                        cur = u.links[i].City2;
                        parent[u.links[i].City2] = u;
                        queue.Enqueue(u.links[i].City2);
                        //untuk bfs draw line masih salah 
                        //drawLine(parent[u.links[i].City2],cur, Color.Red);
                    }
                    else if (!u.links[i].City1.isVisited)
                    {
                        u.links[i].City1.isVisited = true;
                        cur = u.links[i].City1;
                        parent[u.links[i].City1] = u;
                        queue.Enqueue(u.links[i].City1);
                        //untuk bfs draw line masih salah 
                        //drawLine(parent[u.links[i].City1],cur, Color.Red);
                    }
                }
            }
            City dest = goal;
            List<City> path = new List<City>();
            while (dest != null)
            {
                path.Add(dest);
                dest = parent[dest];
            }

            path.Reverse();
            List<string> cityName = new List<string>();
            foreach (var item in path)
            {
                cityName.Add(item.name);
            }
            richTextBox1.Text += "\n ========= \n";
            richTextBox1.Text += "Rute by BFS :\n";
            richTextBox1.Text += string.Join(",", cityName);
        }

        private double UCSdistance(City city1, City city2)
        {
            double deltaY = Math.Abs(city1.getY() - city2.getY());
            double deltaX = Math.Abs(city1.getX() - city2.getX());
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
