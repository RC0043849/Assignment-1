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
                double Width = double.Parse(textBox1.Text);
                double Length = double.Parse(textBox2.Text);
                double Height = double.Parse(textBox3.Text);
                //
                double Volume = Length * Height * Width ;
                double Area = 2 * ((Height * Width)  + (Width * Length ) + (Length * Height) ;
                //
                label1.Text = "Volume =" + Volume;
                label2.Text = "Area =" + Area;


            }
            catch
            {
                MessageBox.Show("oops!");
            }
        }
    }
}
