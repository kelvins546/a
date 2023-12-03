using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quizb
{
    public partial class Form3 : Form
    {
        int avage = 0;
        string wrong1, wrong2, wrong3;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            wrong2 = "2, ";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            wrong2 = "2, ";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            avage++;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 dian = new Form2();
            dian.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           
                MessageBox.Show("Your Current points:  " +avage+ "\nwrong answer in no. : "+wrong1 + wrong2+ wrong3, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Form4 jep = new Form4();    
                jep.Show();
                this.Hide();
            
           




        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            avage++;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            wrong3 = "3";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            avage++;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            wrong1 = "1, ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            wrong1 = "1, ";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            wrong3 = "3";
        }
    }
 }

