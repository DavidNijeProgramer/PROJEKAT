﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NAudio.Wave;


namespace WindowsFormsApplication13
{
    
    public partial class Form1 : Form
    {
        public static string input;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* string[] devices = new string[WaveInEvent.DeviceCount];

            for (int i = 0; i < WaveInEvent.DeviceCount; i++)
            {
                string s = (i + ". " + WaveInEvent.GetCapabilities(i).ProductName);
                devices[i] = s;

            }
            comboBox1.Items.AddRange(devices);
            */

            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = (comboBox1.Text).Substring(0,1);
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sound sound = new Sound();
            sound.StartDetect(int.Parse(textBox1.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}