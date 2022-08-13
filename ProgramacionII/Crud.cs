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
using Entidades.capas.Data;
using Entidades.capas.Data.Models;

namespace ProgramacionII
{
    public partial class Crud : Form
    {   

        //clsBeEntidades Entity = new clsBeEntidades();  
        //clsLnEntidades data = new clsLnEntidades(); 



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
            //this.Dispose();
            MantenimientoEntidades me = new MantenimientoEntidades();
            me.ShowDialog();
                
            if (Program.entidadagregada)
            {
                Program.entidadagregada = false;
                ListarEntidades();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantenimientoEntidades me = new MantenimientoEntidades();
            me.button1.Text = "Actualizar";
            me.Text = "Actualizar Entidad";
            me.identidad = tabla.CurrentRow.Cells[0].Value.ToString();
            me.textBoxdescripcion.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            me.textBoxdireccion.Text = tabla.CurrentRow.Cells[2].Value.ToString();
            me.textBoxLocalidad.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            me.comboentidad.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            me.combodocumento.Text = tabla.CurrentRow.Cells[5].Value.ToString();
            me.textBoxnumerodocumento.Text = tabla.CurrentRow.Cells[6].Value.ToString();
            me.textBoxtelefono.Text = tabla.CurrentRow.Cells[7].Value.ToString();
            me.textBoxpaginaweb.Text = tabla.CurrentRow.Cells[8].Value.ToString();
            me.textBoxFacebook.Text = tabla.CurrentRow.Cells[9].Value.ToString();
            me.textBoxInstagram.Text = tabla.CurrentRow.Cells[10].Value.ToString();
            me.textBoxTwitter.Text = tabla.CurrentRow.Cells[11].Value.ToString();
            me.textBoxTiktok.Text = tabla.CurrentRow.Cells[12].Value.ToString();
            me.textBoxpostalcode.Text = tabla.CurrentRow.Cells[13].Value.ToString();
            me.textBoxgps.Text = tabla.CurrentRow.Cells[14].Value.ToString();
            me.textBoxLimiteCredito.Text = tabla.CurrentRow.Cells[15].Value.ToString();
            me.textBoxUsuario.Text = tabla.CurrentRow.Cells[16].Value.ToString();
            me.textBoxClave.Text = tabla.CurrentRow.Cells[17].Value.ToString();
            me.comboroluser.Text = tabla.CurrentRow.Cells[18].Value.ToString();
            me.textcomentario.Text = tabla.CurrentRow.Cells[19].Value.ToString();
            me.combostatus.Text = tabla.CurrentRow.Cells[20].Value.ToString();

            String temp = tabla.CurrentRow.Cells[21].Value.ToString();
            if(temp == "True")
            {
                me.checkBoxEliminable.Checked = true;
            }
            else { me.checkBoxEliminable.Checked = false; }
     
            me.ShowDialog();
            ListarEntidades();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = tabla.CurrentRow.Cells[0].Value.ToString();
            new clsLnEntidades().Eliminar(ref id);

            ListarEntidades();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBoxbusqueda.Text.Length == 0)
            {
                MessageBox.Show("Debe introducir el username del usuario que deseea buscar.");
            }
            else
            {
                var data = new clsLnEntidades();
                tabla.DataSource = data.Busqueda(textBoxbusqueda.Text);
                textBoxbusqueda.Text = "";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListarEntidades();
        }

        private void Crud_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose(); 
        }
    }
}
