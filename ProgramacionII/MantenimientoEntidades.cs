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
    public partial class MantenimientoEntidades : Form
    {
        public MantenimientoEntidades()
        {
            InitializeComponent();
            cargacombo();
        }

        public MantenimientoEntidades(string user,string pass)
        {
            InitializeComponent();
            cargacombo();
            textBoxUsuario.Text = user;
            textBoxClave.Text = pass;
        }

        private void cargacombo()
        {
            combodocumento.SelectedIndex = 0;
            comboentidad.SelectedIndex = 0;
            comboroluser.SelectedIndex = 0;
            combostatus.SelectedIndex = 0;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
