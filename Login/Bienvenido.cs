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
    public partial class Bienvenido: Form
    {
        public Bienvenido()
        {
            InitializeComponent();
        }
        public Bienvenido(string username)
        {
            InitializeComponent();
            lblBienvenido.Text = "¡Bienvenido, " + username + "!";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }
    }
}
