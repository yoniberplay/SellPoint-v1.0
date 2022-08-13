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
using Entidades.capas.Data;
using Entidades.capas;

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

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean cond = false;

            if (button1.Text == "Guardar")
            {
                 
            cond = validar();
            if (cond)
            {
                this.Dispose();
                Program.entidadagregada = true;
                
            }
            }else if(button1.Text == "Actualizar")
            {
                cond = validar();
                if (cond)
                {
                    this.Dispose();
                    
                }
            }
            
           
           

        }

        private Boolean validar()
        {
            String web = ""; String tiktok = ""; String twitter = ""; String facebook = ""; String instagram = "";
            Boolean cond = false;

            web += textBoxpaginaweb.Text;
            tiktok += textBoxTiktok.Text;
            facebook += textBoxFacebook.Text;
            instagram += textBoxInstagram.Text;
            twitter += textBoxTwitter.Text;

            int condeliminable = 0;
            if (checkBoxEliminable.Checked)
            {
                condeliminable = 1;
            }
            

            String descripcion = textBoxdescripcion.Text;
            String direccion = textBoxdireccion.Text;
            String localidad = textBoxLocalidad.Text;
            String comentario = textcomentario.Text;
            String documento = textBoxnumerodocumento.Text;
            String telefono = textBoxtelefono.Text;
            String limitecredito = textBoxLimiteCredito.Text;
            String gps = textBoxgps.Text;
            String postalcode = textBoxpostalcode.Text;
            String usuario = textBoxUsuario.Text;
            String clave = textBoxClave.Text;


            if (descripcion.Length == 0 || direccion.Length == 0 || documento.Length == 0 || localidad.Length == 0 || telefono.Length == 0 || limitecredito.Length == 0 ||
                comentario.Length == 0 || gps.Length == 0 || postalcode.Length == 0 || usuario.Length == 0 || clave.Length == 0 )
            {
                
               MessageBox.Show("Debe rellenar todos los campos.!");
            }
            else
            {
                int credito = Convert.ToInt32(limitecredito);
                if (credito <= 0)
                {
                    MessageBox.Show("El limite de credito debe ser mayor a cero.!");
                }
                else
                {
                        clsBeEntidades clsBeEntidades = new clsBeEntidades(ref descripcion, direccion, localidad, comboentidad.Text
                , combodocumento.Text, documento, telefono, web, facebook, instagram, twitter, tiktok,
               postalcode, gps, textBoxLimiteCredito.Text, usuario, clave, comboroluser.Text, comentario, combostatus.Text,
                condeliminable);

                    clsLnEntidades clsLnEntidades = new clsLnEntidades();
                    if (button1.Text == "Actualizar")
                    {
                        clsBeEntidades.IdEntidad = identidad;
                        clsLnEntidades.Actualizar(ref clsBeEntidades);
                        cond = true;
                    }
                    else
                    {
                        clsLnEntidades.Insertar(ref clsBeEntidades);
                        MessageBox.Show("Entidad guardada, satisfactoriamente.!", "Registro Exitoso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cond = true;
                    }
                }

                
            }

            

            return cond;
        }

        private void textBoxnumerodocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            solonumeros(e);

        }

        private void textBoxtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            solonumeros(e);
        }

        private void textBoxLimiteCredito_KeyPress(object sender, KeyPressEventArgs e)
        {

            solonumeros(e);
        }

        private void solonumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MantenimientoEntidades_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
