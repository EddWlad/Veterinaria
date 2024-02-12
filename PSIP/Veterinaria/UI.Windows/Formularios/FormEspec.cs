using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI.Windows.Controladores;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class FormEspec : Form
    {
        EspecieVistaModelo especieVistaModelo;
        EspecieControlador especieControlador;
        public FormEspec()
        {
            InitializeComponent();
            especieVistaModelo = new EspecieVistaModelo();
            especieControlador = new EspecieControlador();
        }
        private void InsertarEspecie()

        {

            if (especieControlador.InsertarEspecie(especieVistaModelo))
            {
                MessageBox.Show("Especie insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al insertar Especie.");
            }
        }
        private void ModificarEspecie()

        {

            if (especieControlador.ModificarEspecie(especieVistaModelo))
            {
                MessageBox.Show("Especie Modificada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al Modificar Especie.");
            }
        }

        private void ListarEspecies()
        {
            List<Especie> listaEspecie = (List<Especie>)especieControlador.ListarEspecieActivos();
            foreach (Especie item in listaEspecie)
            {
                dtgEspecie.Rows.Add(new object[] {"",item.ID_Especie,item.Nom_Especie});
            }
        }
        public void limpiar()
        {
            txtId.Text = "";
            txtEspecie.Text = "";
            txtIndice.Text = "";
        }
       
        private void FormEspec_Load(object sender, EventArgs e)
        {
            ListarEspecies();
        }




        private void dtgEspecie_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dtgEspecie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgEspecie.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtId.Text = dtgEspecie.Rows[indice].Cells["id_especie"].Value.ToString();
                    txtEspecie.Text = dtgEspecie.Rows[indice].Cells["especie"].Value.ToString();

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            especieVistaModelo.Nom_Especie = txtEspecie.Text;
            especieVistaModelo.Est_Especie = 1;
            InsertarEspecie();
            limpiar();
            dtgEspecie.Rows.Clear();
            ListarEspecies();

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("El Id de la especie no fue encontrado");
                return;
            }
            especieVistaModelo.ID_Especie = int.Parse(txtId.Text);
            especieVistaModelo.Nom_Especie = txtEspecie.Text;
            especieVistaModelo.Est_Especie = 1;
            ModificarEspecie();
            limpiar();
            dtgEspecie.Rows.Clear();
            ListarEspecies();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("El Id del cliente no fue encontrado");
                return;
            }

            var eliminacionEspecie = especieControlador.EliminarEspecie(int.Parse(txtId.Text));
            if (eliminacionEspecie)
            {
                MessageBox.Show("Especie eliminado correctamente");

            }
            else
            {
                MessageBox.Show("Error: Al elimnar especie");
            }
            dtgEspecie.Rows.Clear();
            limpiar();
            ListarEspecies();
        }
    }
}
