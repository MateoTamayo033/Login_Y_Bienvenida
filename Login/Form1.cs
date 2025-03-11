using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
                string username = txbUser.Text;
                string password = txbPass.Text;

                if (IsValidAdmin(username, password))
                {
                Bienvenido welcomeForm = new Bienvenido(username);
                    welcomeForm.Show(); 
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Intente de nuevo.");
                }
            }

        private bool IsValidAdmin(string username, string password)
        {
            string validUsername = "admin";
            string validPassword = "admin123";

            return username == validUsername && password == validPassword;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}