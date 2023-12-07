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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SportsiTim
{
    public partial class DodajIgraca : Form
    {

        private const string Igrac = "data.txt"; // Specify your file name
        private IgracForm dodajIgracaform;
        public DodajIgraca()
        {
            InitializeComponent();
            dodajIgracaform = new IgracForm();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dodajIgracaform.LoadDataToListBox(Igrac);
            dodajIgracaform.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textToAdd = textBox1.Text;

            try
            {
                // Append the text to the file using StreamWriter
                using (StreamWriter writer = new StreamWriter(Igrac, true))
                {
                    writer.WriteLine(textToAdd);
                }

                MessageBox.Show("Text added to file successfully!");

                // Clear the TextBox after adding to the file
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding text: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ime


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
