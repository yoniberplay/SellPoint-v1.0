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
            labelstatus.Text = " Conectado.  "+ DateTime.Now.ToString("h:mm dd/MM/yyyy");
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
            //labelrol.Text = bc.RolUserEntidad;
            //labelusername.Text = bc.UserNameEntidad;



        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crud crud = new Crud();
            crud.MdiParent = this;
            crud.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
