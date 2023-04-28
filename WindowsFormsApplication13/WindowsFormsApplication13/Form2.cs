using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
