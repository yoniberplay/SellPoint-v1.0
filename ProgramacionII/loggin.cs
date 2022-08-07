using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            // Almacenamiento del método encargado de verificar las credenciales
            //bool isAuthenticated = loginService.ValidateAuth(txtUsername.Text, txtPassword.Text);
            //UserName = txtUsername.Text;

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
                    new MenuPrincipal().Show();
                    this.Hide();
                }
                else
                {
                 MessageBox.Show("Datos incorrectos.");
                }

            }
           


        }


      

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
