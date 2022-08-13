using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.capas;
using Entidades.capas.Data.Models;

namespace ProgramacionII
{
    public partial class loggin : Form
    {


        public loggin()
        {
            InitializeComponent();

        }

        private void loggin_Load(object sender, EventArgs e)
        {

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Porfavor, complete ambos campos!");
            }

            else
            {
                clsBeEntidades em = new clsBeEntidades();
                clsLnEntidades clsLnEntidades = new clsLnEntidades();

                em.UserNameEntidad = txtUsername.Text;
                em.PassworEntidad = txtPassword.Text;

                if(clsLnEntidades.Obtener(ref em))
                {
                   
                    Program.validateloggin = true;
                    Program.username = txtUsername.Text;
                    this.Dispose();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Su usuario o clave son incorrectos.", "Datos incorrectos.", MessageBoxButtons.OK);
                }

            }
           


        }


        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)13)
            {
                btnIngresar_Click(sender,e);
            }
        
    }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
