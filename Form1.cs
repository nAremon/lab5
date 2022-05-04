﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button btn = new Button();
                this.Controls.Add(btn);
                btn.Location = new Point(e.X, e.Y);
                btn.Text = string.Format("{0}, {1}", e.X, e.Y);
                btn.Click += new EventHandler(btn_Click);
                
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {

        }
    }
}
