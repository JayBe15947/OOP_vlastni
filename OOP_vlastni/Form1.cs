using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_vlastni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hodinky hodinky;
        ChytreHodinky chytreHodinky;
        private void button1_Click(object sender, EventArgs e)
        {
            hodinky = new Hodinky(textBox1.Text,textBox2.Text, textBox3.Text);
            MessageBox.Show(hodinky.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hodinky.Cas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //hodinky = new Hodinky(textBox1.Text, textBox2.Text, textBox3.Text);
            hodinky.Spust();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            hodinky.Zastav();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chytreHodinky = new ChytreHodinky(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            MessageBox.Show(chytreHodinky.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //hodinky = new Hodinky(textBox1.Text, textBox2.Text, textBox3.Text);
            hodinky.Cas();
        }
    }
}
