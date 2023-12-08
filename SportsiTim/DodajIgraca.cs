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

        private const string Igrac = "C:\\Users\\Ucenik\\Desktop\\nesto.txt"; // Specify your file name
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
            string textToAdd1 = textBox1.Text;
            string textToAdd2 = textBox2.Text;
            string textToAdd3 = textBox3.Text;
            string textToAdd4 = textBox4.Text;
            string textToAdd5 = textBox5.Text;
            string textToAdd6 = textBox6.Text;

            try
            {
                // Append the text to the file using StreamWriter
                using (StreamWriter writer = new StreamWriter(Igrac, true))
                {
                    writer.WriteLine(textToAdd1 , textToAdd2) ;
                    writer.WriteLine(textToAdd2);
                    writer.WriteLine(textToAdd3);
                    writer.WriteLine(textToAdd4);
                    writer.WriteLine(textToAdd5);
                    writer.WriteLine(textToAdd6);
                }

                MessageBox.Show("Text added to file successfully!");

                // Clear the TextBox after adding to the file
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
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
