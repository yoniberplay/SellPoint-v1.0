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
                    //new MenuPrincipal(em.UserNameEntidad).Show();
                    //this.Hide();
                    Program.validateloggin = true;
                    Program.username = txtUsername.Text;
                    this.Dispose();
                }
                else
                {
                    Program.addclave = txtPassword.Text;
                    Program.addusername = txtUsername.Text;
                   // MantenimientoEntidades mantenimiento = new MantenimientoEntidades(txtUsername.Text, txtPassword.Text);
                   //mantenimiento.Show();
                    this.Dispose();
                    //MessageBox.Show("Datos incorrectos.");
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
