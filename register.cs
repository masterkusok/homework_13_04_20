﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace learnink
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            File.AppendAllText("data_base.txt", textBox1.Text + "\r\n");
            File.AppendAllText("data_base.txt", textBox2.Text + "\r\n");
            this.Hide();
        }
    }
}
