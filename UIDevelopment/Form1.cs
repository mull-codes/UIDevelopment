using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIDevelopment.classes;

namespace UIDevelopment
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string>();
        List<PostLayout> postList = new List<PostLayout>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            

        }

        public void DrawRect()
        {
            names.Add("Name 1");
            names.Add("Name 2");
            names.Add("Name 3");
            names.Add("Name 4");
            names.Add("Name 5");
            names.Add("Name 6");
            names.Add("Name 7");

            int counter = 0, newPos = 0;
            foreach (string name in names)
            {
                counter++;
                PostLayout tempLayout = new PostLayout(name, this, counter, 20);
                postList.Add(tempLayout);
            }

            counter = 0;
            foreach (PostLayout item in postList)
            {
                counter++;
                //newPos = item.GetPos() * counter; 
                item.DrawUI(counter);
                newPos = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawRect();
        }
    }
}
