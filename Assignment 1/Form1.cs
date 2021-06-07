using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cuboid_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                // read force and angle from textboxes
                double Height = double.Parse(textBox1.Text);
                double Length = double.Parse(textBox2.Text);
                double Width = double.Parse(textBox3.Text);
                //
                double Volume = Length * Height * Width;
                double Area = 2 * ((Height * Width) + (Width * Length) + (Length * Height));
                //
                SA1.Text = " Surface Area =" + Area;
                V1.Text = "Volume =" + Volume;


            }
            catch
            {
                MessageBox.Show("oops!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate2_Click(object sender, EventArgs e)
        {
            try
            {
                // read radius from text box
                double Radius = double.Parse(textBox4.Text);
                //
                double Area = 4 * Math.PI * (Radius * Radius);
                double Volume = (4 / 3) * Math.PI * (Radius * Radius * Radius);
                //
                SA2.Text = "Surface area = " + Area;
                V2.Text = "Volume = " + Volume;


            }
            catch
            {
                MessageBox.Show("oops!");
            }
        }

        private void SA2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // read radius and hight from text boxes
                double height = double.Parse(textBox5.Text);
                double Radius = double.Parse(textBox6.Text);
                //
                double Area = (Math.PI * Radius) * (Radius + (Math.Sqrt(Height * Height + Radius * Radius)));
                double Volume = (1.0 / 3.0 * Math.PI) * (Radius * Radius) * Height;
                //
                SA3.Text = "Surface area = " + Area;
                V3.Text = "Volume = " + Volume;
             

            }
            catch
            {
                MessageBox.Show("oops!");
            }
    }
    }
}