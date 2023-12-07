using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        internal void LoadDataToListBox(string igrac)
        {
            try
            {
                listBox.Items.Clear();

                // Read data from the file using StreamReader and populate the ListBox
                using (StreamReader reader = new StreamReader(Igrac))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox.Items.Add(line);
                    }
                }

                MessageBox.Show("Data loaded to ListBox successfully!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"File '{Igrac}' not found. Save some text first.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Igrac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
