using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database2
{
    public partial class FormAdmincs : Form
    {
        public FormAdmincs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appsettings appsettings1 = new appsettings();
            appsettings1.saveUser(textBox1.Text, textBox2.Text, textBox3.Text, password_text.Text, textBox5.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            password_text.Visible= true;
            textBox5.Visible = true;
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Visible = true;
            label5.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            appsettings appsettings1 = new appsettings();
            appsettings1.updateUser(password_text.Text, textBox5.Text,textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
