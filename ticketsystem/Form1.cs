using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        int ytş=1, çocuk=0, yaşlı=0;
        int key;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ytş>0)
            ytş--;
            if (ytş < 0) ytş = 0;
            label3.Text = ytş.ToString();
              
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = System.DateTime.Now;
            dateTimePicker2.MinDate = System.DateTime.Now;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            comboBox2.Visible = false;
            label2.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            label2.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ytş++;
            if (ytş > 9) ytş = 9;
            label3.Text = ytş.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            çocuk++;
            if (çocuk > 9) çocuk = 9;
            label4.Text = çocuk.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(çocuk > 0)
            çocuk--;
            if (çocuk < 0) çocuk = 0;
            label4.Text = çocuk.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            yaşlı++;
            if (yaşlı > 9) yaşlı = 9;
            label5.Text = yaşlı.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (yaşlı > 0)
                yaşlı--;
            if (yaşlı < 0) yaşlı = 0;
            label5.Text = yaşlı.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
