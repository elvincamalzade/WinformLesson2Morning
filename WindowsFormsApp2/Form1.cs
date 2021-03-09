using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          //  CreateLabel();
        }

        void CreateLabel()
        {
            Label label = new Label();
            Image image = Properties.Resources.ferrari1;

            label.Size = new Size(image.Width, image.Height);

            label.Image = image;

            this.Controls.Add(label);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
           // MessageBox.Show($"Welcome {fullnameTxtb.Text}");

        }

        private void fullnameTxtb_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            if (fullnameTxtb.Text == "email")
            {
                fullnameTxtb.BackColor = Color.Green;
            }
            else
            {
                fullnameTxtb.BackColor = Color.Red;
            }
        }

        private void fullnameTxtb_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void fullnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.SelectedText);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
          //  richTextBox1.Paste();
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Text = "Visa : Selected";
            }
            else
            {
                radioButton1.Text = "Visa : UnSelected";

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.Text = "Master : Selected";
            }
            else
            {
                radioButton2.Text = "Master : UnSelected";

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.Green;
            }
            else
            {

                checkBox1.BackColor = Color.White;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.BackColor = Color.Green;
            }
            else
            {

                checkBox2.BackColor = Color.White;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.BackColor = Color.Green;
            }
            else
            {

                checkBox3.BackColor = Color.White;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker1.Text;
                
          
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
