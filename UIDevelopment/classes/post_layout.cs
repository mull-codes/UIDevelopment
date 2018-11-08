using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDevelopment.classes
{
    class PostLayout : Form
    {
        //Controls.
        private Color bgColor = new Color();
        private TextBox textbox = new TextBox();
        private Button button = new Button();
        private ListBox listbox = new ListBox();
        private CheckBox checkbox = new CheckBox();
        private Label label = new Label();
        private int rectX;
        private int rectY;
        private int rectHeight;
        private int rectWidth;
        private int defaultPosY = 40;
        private int tbX;
        private int tbY;

        private Form refForm;

        //Values
        private string content;
        private DateTime dateTime;

        public PostLayout(string content, Form form, int counter, int marginBottom)
        {
            this.rectX = 30;
            this.rectY = (this.defaultPosY * counter);
            this.rectHeight = 50;
            this.rectWidth = 300;
            this.content = content;
            this.refForm = form;
        }

        public int GetPos()
        {
            return this.rectY;
        }

        public void DrawUI(int counter)
        {
            this.tbX = 35;
            this.tbY = this.GetPos() + 5;
            

            Label tb1 = new Label();
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = refForm.CreateGraphics();
            Rectangle rect = new Rectangle(this.rectX, this.rectY, this.rectWidth, this.rectHeight);
            formGraphics.FillRectangle(myBrush, rect);
            myBrush.Dispose();
            formGraphics.Dispose();

            System.Drawing.SolidBrush myBrushSeparator = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphicsSeparator;
            formGraphicsSeparator = refForm.CreateGraphics();

            int sepPost = ((this.rectY + this.defaultPosY) + 5);

            Rectangle rectSeparator = new Rectangle(this.rectX, sepPost, this.rectWidth, 5);
            formGraphicsSeparator.FillRectangle(myBrushSeparator, rectSeparator);
            myBrushSeparator.Dispose();
            formGraphicsSeparator.Dispose();

            tb1.Location = new System.Drawing.Point(35, this.tbY);
            tb1.Width = 290;
            tb1.Height = 20;
            tb1.Text = "rectY: " + this.rectY + ", tbY: " + this.tbY + ", Height: " + this.rectHeight;
            refForm.Controls.Add(tb1);
            //this.Controls.Add(tb1);

            //MessageBox.Show(" : rectX: " + this.rectX + ", rectY: " + this.rectY);
        }
    }
}
