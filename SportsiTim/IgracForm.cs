﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsiTim
{
    public partial class IgracForm : Form
    {
        public IgracForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DodajIgraca().Show();
           Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            Close();

        }
    }
}
