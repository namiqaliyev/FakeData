﻿using _FakeData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _TestWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(NameData.GetMaleFirstName() + " " + NameData.GetMaleSurname() + " " + NetworkData.GetMaleMailAddress("gmail.com"));
            }
            
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
