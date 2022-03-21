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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appsettings appsettings1 = new appsettings();

            string userType = appsettings1.checkusertype(textBox1.Text, textBox2.Text);
            
        if (userType.Equals("Admin"))
           {
                FormAdmincs formAdmincs = new FormAdmincs();
                formAdmincs.Show();
           }
        else   if (userType.Equals("User"))
            {
                FormUser formuser = new FormUser();
                formuser.Show();
            }


        }
    }
}
