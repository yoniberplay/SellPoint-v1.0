using Entidades.capas.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionII
{
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal(String usuario)
        {
            InitializeComponent();
            clsLnEntidades cl = new clsLnEntidades();
            clsBeEntidades bc = cl.UsuarioConectado(usuario);
           //
            labelstatus.Text = " Conectado.  "+ DateTime.Now.ToString("h:mm tt | dd/MM/yyyy");
            textBoxnumerodocumento.Text = bc.NumeroDocumento;
            textBoxdireccion.Text = bc.Direccion;
            textBoxestadoentidad.Text = bc.Estatus;
            textBoxestadoentidad.ForeColor = System.Drawing.Color.Lime;
            textBoxlocalidad.Text = bc.Localidad;
            textBoxnodocumento.Text = bc.NumeroDocumento;
            textBoxtelefono.Text = bc.Teléfonos;
            textBoxtipodocumento.Text = bc.TipoDocumento;
            textBoxtipoentidad.Text = bc.TipoEntidad;
            textBoxusername.Text = bc.UserNameEntidad;
            textBoxroluser.Text = bc.RolUserEntidad;
           

        }

       

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crud crud = new Crud();
            crud.MdiParent = this;
            crud.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new loggin().Show();
            this.Hide();
        }

        private void aCercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade a = new Acercade();
            a.MdiParent = this;
            a.Show();   
        }
    }
}
