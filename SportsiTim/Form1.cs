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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new IgracForm().Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TimForm().Show();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new IgracuTimu().Show();
         
        }


        
    }
    }
  

