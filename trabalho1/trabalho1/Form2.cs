using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmailLogin.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Campos obrigatórios");
            }
            else 
            {
                if (txtEmailLogin.Text == "gabriel" && txtPassword.Text == "1234")
                {
                   Form1 frm = new Form1();
                    frm.Show();
                   
                }
                else
                {
                    MessageBox.Show("Login Incorreto");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
