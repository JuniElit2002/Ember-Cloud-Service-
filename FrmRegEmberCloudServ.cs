using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEmber
{
    public partial class FrmRegEmberCloudServ : Form
    {
        public FrmRegEmberCloudServ()
        {
            InitializeComponent();
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtNumeroTelefono.Text) ||
        string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.");
                return;
            }
            RegistroCliente RegistroCliente = new RegistroCliente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NumeroTelefono = txtNumeroTelefono.Text,
                CorreoElectronico = txtCorreoElectronico.Text
            };

            MessageBox.Show("Datos guardados correctamente");

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNumeroTelefono.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
    }

