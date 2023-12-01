using System;
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
    public partial class DodajTim : Form
    {
        public DodajTim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
