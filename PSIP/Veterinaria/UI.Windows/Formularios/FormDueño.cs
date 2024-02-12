using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI.Windows.Controladores;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class FormDueño : Form
    {
        DueñoControlador dueñoControlador;
        DueñoVistaModelo dueñoVistaModelo;
        public FormDueño()
        {
            InitializeComponent();
            dueñoVistaModelo = new DueñoVistaModelo();
            dueñoControlador = new DueñoControlador();
        }
        private void InsertarDueño()

        {

            if (dueñoControlador.InsertarDueño(dueñoVistaModelo))
            {
                MessageBox.Show("Dueño insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al insertar Dueño.");
            }
        }
        private void ModificarDueño()

        {

            if (dueñoControlador.ModificarDueño(dueñoVistaModelo))
            {
                MessageBox.Show("Dueño Modificada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al Modificar Dueño.");
            }
        }
        private void FormDueño_Load(object sender, EventArgs e)
        {
            ListarCLientes();
        }
        private void ListarCLientes()
        {
            List<Dueño> listaClientes = (List<Dueño>)dueñoControlador.ListarDueñoActivos();
            foreach(Dueño item in listaClientes)
            {
                dataGridView2.Rows.Add(new object[] {"",item.ID_Dueño_Cedula,item.Nombre_Dueño,item.Apellido_Dueño,item.Dirección_Dueño,
                item.Telefono_Dueño,item.Email_Dueño});
            }
        }
      
        private void Guardar_Especialista_Click(object sender, EventArgs e)
        {
            dueñoVistaModelo.ID_Dueño_Cedula = txtCedula.Text;
            dueñoVistaModelo.Nombre_Dueño = txtNombre.Text;
            dueñoVistaModelo.Apellido_Dueño = txtApellido.Text;
            dueñoVistaModelo.Dirección_Dueño = txtDireccion.Text;
            dueñoVistaModelo.Telefono_Dueño = txtTelefono.Text;
            dueñoVistaModelo.Email_Dueño = txtEmail.Text;
            dueñoVistaModelo.Est_Dueño = 1;
            InsertarDueño();
            dataGridView2.Rows.Clear();
            ListarCLientes();
            limpiar();

        }
        public void limpiar()
        {

            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtCedula.Text = dataGridView2.Rows[indice].Cells["Cedula"].Value.ToString();
                    txtNombre.Text = dataGridView2.Rows[indice].Cells["nombre"].Value.ToString();
                    txtApellido.Text = dataGridView2.Rows[indice].Cells["apellido"].Value.ToString();
                    txtDireccion.Text = dataGridView2.Rows[indice].Cells["direccion"].Value.ToString();
                    txtTelefono.Text = dataGridView2.Rows[indice].Cells["telefono"].Value.ToString();
                    txtEmail.Text = dataGridView2.Rows[indice].Cells["email"].Value.ToString();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("El Id de la especie no fue encontrado");
                return;
            }
            dueñoVistaModelo.ID_Dueño_Cedula = txtCedula.Text;
            dueñoVistaModelo.Nombre_Dueño = txtNombre.Text;
            dueñoVistaModelo.Apellido_Dueño = txtApellido.Text;
            dueñoVistaModelo.Dirección_Dueño = txtDireccion.Text;
            dueñoVistaModelo.Telefono_Dueño = txtTelefono.Text;
            dueñoVistaModelo.Email_Dueño = txtEmail.Text;
            dueñoVistaModelo.Est_Dueño = 1;
            ModificarDueño();
            limpiar();
            dataGridView2.Rows.Clear();
            ListarCLientes();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("El Id del cliente no fue encontrado");
                return;
            }

            var eliminacionCliente = dueñoControlador.EliminarCliente(txtCedula.Text);
            if (eliminacionCliente)
            {
                MessageBox.Show("Cliente eliminado correctamente");

            }
            else
            {
                MessageBox.Show("Error: Al elimnar cliente");
            }
            dataGridView2.Rows.Clear();
            limpiar();
            ListarCLientes();
        }

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var imgWidth = Properties.Resources.check_circle_solid_24.Width;
                var imgHeight = Properties.Resources.check_circle_solid_24.Height;
                var imgX = e.CellBounds.Left + (e.CellBounds.Width - imgWidth) / 2;
                var imgY = e.CellBounds.Top + (e.CellBounds.Height - imgHeight) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_circle_solid_24, new Rectangle(imgX, imgY, imgWidth, imgHeight));
                e.Handled = true;
            }
        }
    }
}
