using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ED
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            textBox1.UseSystemPasswordChar = true;

            this.BackColor = Color.FromArgb(32, 32, 32); 
            this.ForeColor = Color.Gray; 

            textBox1.BackColor = Color.FromArgb(50, 50, 50); 
            textBox1.ForeColor = Color.White; 


            button1.BackColor = Color.DarkGreen;
            button1.ForeColor = Color.White; 

            button2.BackColor = Color.DarkGreen;
            button2.ForeColor = Color.White; 

            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;


        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password_user = "1234";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe de ingresar la contraseña");
                return;
            }
            if(password_user == textBox1.Text)
            {
                this.Hide(); 
                Form1 form1 = new Form1();
                form1.ShowDialog(); 
                this.Close(); 
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
