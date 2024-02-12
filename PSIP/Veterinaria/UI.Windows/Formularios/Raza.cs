using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI.Windows.Controladores;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class Raza : Form
    {
        RazaVistaModelo razaVistaModelo;
        RazaControlador razaControlador;
        public Raza()
        {
            InitializeComponent();
            razaVistaModelo = new RazaVistaModelo();
            razaControlador = new RazaControlador();
        }
        private void InsertarRaza()

        {

            if (razaControlador.InsertarRaza(razaVistaModelo))
            {
                MessageBox.Show("Raza insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al insertar Raza.");
            }
        }
        private void ModificarRaza()

        {

            if (razaControlador.ModificarRaza(razaVistaModelo))
            {
                MessageBox.Show("Raza Modificada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al Modificar Raza.");
            }
        }
        private void Raza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinaria_FinalDataSet7.Raza' Puede moverla o quitarla según sea necesario.

            ListarRaza();
      
        }


        private void ListarRaza()
        {
            IEnumerable<DominioModelo.Entidades.Raza> listarRaza = razaControlador.ListarRazaActivos();

            // Itera sobre cada Raza en la lista y añade sus propiedades al DataGridView
            foreach (DominioModelo.Entidades.Raza item in listarRaza)
            {
                dtgRaza.Rows.Add(new object[] { "", item.ID_Raza, item.Nombre_Raza });
            }
        }
        public void Limpiar()
        {
            txtId.Text = "";
            txtRaza.Text = "";
        }




        private void dtgRaza_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dtgRaza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgRaza.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtId.Text = dtgRaza.Rows[indice].Cells["id_raza"].Value.ToString();
                    txtRaza.Text = dtgRaza.Rows[indice].Cells["razas"].Value.ToString();

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            razaVistaModelo.Nombre_Raza = txtRaza.Text;
            razaVistaModelo.Est_Raza = 1;
            InsertarRaza();
            dtgRaza.Rows.Clear();
            ListarRaza();
            Limpiar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("El Id de la especie no fue encontrado");
                return;
            }
            razaVistaModelo.ID_Raza = int.Parse(txtId.Text);
            razaVistaModelo.Nombre_Raza = txtRaza.Text;
            razaVistaModelo.Est_Raza = 1;
            ModificarRaza();
            dtgRaza.Rows.Clear();
            ListarRaza();
            Limpiar();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("El Id del cliente no fue encontrado");
                return;
            }

            var eliminacionRaza = razaControlador.EliminarRaza(int.Parse(txtId.Text));
            if (eliminacionRaza)
            {
                MessageBox.Show("Raza eliminado correctamente");

            }
            else
            {
                MessageBox.Show("Error: Al elimnar especie");
            }
            dtgRaza.Rows.Clear();
            Limpiar();
            ListarRaza();
        }
    }
}
