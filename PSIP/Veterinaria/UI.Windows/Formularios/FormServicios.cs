using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI.Windows.Controladores;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class FormServicios : Form
    {
        ServiciosControlador servicioControlador;
        ServiciosVistaModelo servicioVistaModelo;
        public FormServicios()
        {
            InitializeComponent();
            servicioVistaModelo = new ServiciosVistaModelo();
            servicioControlador = new ServiciosControlador();
        }
        private void InsertarServicios()

        {

            if (servicioControlador.InsertarServicios(servicioVistaModelo))
            {
                MessageBox.Show("Servicio insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al insertar Servicio.");
            }
        }
        private void ModificarServicio()

        {

            if (servicioControlador.ModificarServicio(servicioVistaModelo))
            {
                MessageBox.Show("Servicio Modificada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al Modificar Servicio.");
            }
        }
        private void Guardar_Especialista_Click(object sender, EventArgs e)
        {
            servicioVistaModelo.Nombre_Serv = Nom_Serviciotxt.Text;
            servicioVistaModelo.Descripcion_Serv = Des_Serviciotxt.Text;
            servicioVistaModelo.Est_Serv = 1;
            InsertarServicios();
            dtgServicios.Rows.Clear();
            ListarServicios();
            Limpiar();
        }
        public void Limpiar()
        {
            txtId.Text = "";
            Nom_Serviciotxt.Text = "";
            Des_Serviciotxt.Text = "";
        }
        private void ListarServicios()
        {
            List<Servicios> listaServicios = (List<Servicios>)servicioControlador.ListarServiciosActivos();
            foreach (Servicios item in listaServicios)
            {
                dtgServicios.Rows.Add(new object[] { "", item.ID_Servicio, item.Nombre_Serv, item.Descripcion_Serv});
            }
        }

        private void FormServicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinaria_FinalDataSet3.Servicios' Puede moverla o quitarla según sea necesario.
            ListarServicios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgServicios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtId.Text = dtgServicios.Rows[indice].Cells["id_servicio"].Value.ToString();
                    Nom_Serviciotxt.Text = dtgServicios.Rows[indice].Cells["nombre"].Value.ToString();
                    Des_Serviciotxt.Text = dtgServicios.Rows[indice].Cells["descripcion"].Value.ToString();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("El Id del servicio no fue encontrado");
                return;
            }
            servicioVistaModelo.ID_Servicio = int.Parse(txtId.Text);
            servicioVistaModelo.Nombre_Serv = Nom_Serviciotxt.Text;
            servicioVistaModelo.Descripcion_Serv = Des_Serviciotxt.Text;
            servicioVistaModelo.Est_Serv = 1;
            ModificarServicio();
            dtgServicios.Rows.Clear();
            ListarServicios();
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("El Id del cliente no fue encontrado");
                return;
            }

            var eliminacionEspecie = servicioControlador.EliminarServicio(int.Parse(txtId.Text));
            if (eliminacionEspecie)
            {
                MessageBox.Show("Especie eliminado correctamente");

            }
            else
            {
                MessageBox.Show("Error: Al elimnar especie");
            }
            dtgServicios.Rows.Clear();
            Limpiar();
            ListarServicios();
        }

        private void dtgServicios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
