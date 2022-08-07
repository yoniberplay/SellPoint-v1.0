using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.capas.Data;
using Entidades.capas.Data.Models;

namespace ProgramacionII
{
    public partial class Crud : Form
    {   

        clsBeEntidades Entity = new clsBeEntidades();  
        clsLnEntidades data = new clsLnEntidades(); 



        public Crud()
        {
            InitializeComponent();
            ListarEntidades();
        }
        
        public void ListarEntidades()
        {
            var data = new clsLnEntidades();
            tabla.DataSource = data.Listar();

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MantenimientoEntidades me = new MantenimientoEntidades();
            me.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenimientoEntidades me = new MantenimientoEntidades();
            me.button1.Text = "Actualizar";
            me.Show();
        }
    }
}
