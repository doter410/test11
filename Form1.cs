using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
namespace LR4 {
    public partial class Form1 : Form {
        public enum Item { Circle, Ellipse }
        private static Graphics g;
        private static Pen p;
        private static ArrayList shapes;
        public Form1() {
            InitializeComponent();
            p = new Pen(Color.Black, 2);
            g = panel1.CreateGraphics();
            selecting();
            shapes = new ArrayList();
        }
        public static void draw(Item item, float x, float y, float r1, float r2, string info) {
            switch (item)  {
                case Item.Circle: g.DrawEllipse(p, x, y, r1, r1); break;
                case Item.Ellipse: g.DrawEllipse(p, x, y, r1, r2); break;
            }
            double sumper = 0;
            foreach (CGraphicsObject ss in shapes) { sumper += ss; }
            richTextBox1.Text = info+"\nSum of perimers: "+Math.Round(sumper, 2);
        }
        private void selecting() {
            if (this.listBox1.GetSelected(0)) {
                this.label4.Visible = false;
                this.textBox4.Visible = false;
                this.textBox4.Text = "0";
                this.label3.Text = "Enter R";
                richTextBox1.Text = "";
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
            }
            else if (this.listBox1.GetSelected(1)) {
                this.label4.Visible = true;
                this.textBox4.Visible = true;
                this.textBox4.Text = "";
                this.label3.Text = "Enter R1";
                richTextBox1.Text = "";
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
            }
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) { selecting(); }

        private void Button1_Click(object sender, EventArgs e) {
            double x, y, r1, r2;
            if (double.TryParse(this.textBox1.Text, out x) && double.TryParse(this.textBox2.Text, out y) && double.TryParse(this.textBox3.Text, out r1) && double.TryParse(this.textBox4.Text, out r2)) {
                if (this.listBox1.GetSelected(0)) {
                    Circle c = new Circle(x, y, r1);
                    shapes.Add(c);
                    c.Show();
                }
                else if (this.listBox1.GetSelected(1)) {
                    Ellipse el = new Ellipse(x, y, r1, r2);
                    shapes.Add(el);
                    el.Show();
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e) {
            g.Clear(Color.White);
            richTextBox1.Text = "";
            shapes.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
