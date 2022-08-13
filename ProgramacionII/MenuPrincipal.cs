using Entidades.capas;
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

            //labelstatus.Text = " Conectado.  "+ DateTime.Now.ToString("h:mm tt | dd/MM/yyyy");
            //labelstatus.Text = " Conectado.  " + DateTime.Now.ToString("h:mm tt | "+""+DateTime.Now.ToLongDateString());
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
            Program.salidaMenuPrincipal = false;
            this.Dispose();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.loggindesdemenuprincipal = true;
            this.Dispose();
        }

        private void aCercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade a = new Acercade();
            a.MdiParent = this;
            a.Show();   
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void labelstatus_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelstatus.Text =DateTime.Now.ToString("h:mm:ss tt")+" "+ DateTime.Now.ToLongDateString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Realmente desea salir del sistema?", "Cerrar sistema", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Program.salidaMenuPrincipal = false;
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }
           
        }
    }
}
