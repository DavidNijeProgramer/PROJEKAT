using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication13
{
    public partial class Form2 : Form
    {   
        public Form2()
        {
            InitializeComponent();
            label1.Text = Form1.input;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.input;
            AllocConsole();

        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer2.Enabled = true;
            timer2.Start();

           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Sound sound = new Sound();
            //float f =
            sound.StartDetect(int.Parse(label1.Text));
           // label3.Text = f.ToString();
            //trackBar1.Value = Convert.ToInt32(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer2.Stop();
        }
    }
}
