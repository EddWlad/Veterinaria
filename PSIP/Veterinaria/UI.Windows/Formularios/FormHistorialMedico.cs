using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI.Windows.Controladores;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class FormHistorialMedico : Form
    {
        HistorialMedicoControlador historialMedicoControlador;
        HistorialMedicoVistaModelo historialMedicoVistaModelo;
        DueñoControlador dueñocontrolador;
        AnimalesControlador animalcontrolador;
        List<HistorialMascotaDueño> listarHistorial;
        public FormHistorialMedico()
        {
            InitializeComponent();
            historialMedicoVistaModelo = new HistorialMedicoVistaModelo();
            historialMedicoControlador = new HistorialMedicoControlador();
            dueñocontrolador = new DueñoControlador();
            animalcontrolador = new AnimalesControlador();
        }
        private void ListarDueños()
        {
            //var nombredueño = dueñocontrolador.ListarDueño().Select(x => new DueñoCBVistaModelo { ID_Dueño_Cedula = x.ID_Dueño_Cedula, Nombre_Dueño = $"{x.Nombre_Dueño} {x.Apellido_Dueño}" }).ToList();

            DueñoCB.DataSource = dueñocontrolador.ListarDueñoActivos();
            DueñoCB.DisplayMember = "Nombre_Dueño";
            DueñoCB.ValueMember = "ID_Dueño_Cedula";
        }
        private void ListarAnimales()
        {

            MascotaCB.DataSource = animalcontrolador.ListarAnimalesActivos();
            MascotaCB.DisplayMember = "nombre_mascota";
            MascotaCB.ValueMember = "id_Animal";
        }
        private void InsertarHistorialMedico()

        {

            if (historialMedicoControlador.InsertarHistorialMedico(historialMedicoVistaModelo))
            {
                MessageBox.Show("Historial insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al insertar Historial.");
            }
        }
        private void ModificarHistorial_Medico()

        {

            if (historialMedicoControlador.ModificarHistorial_Medico(historialMedicoVistaModelo))
            {
                MessageBox.Show("Historial Modificada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al Modificar Historial.");
            }
        }
        private void Guardar_Especialista_Click(object sender, EventArgs e)
        {
            
            historialMedicoVistaModelo.Diagnostico = DiagnosticoTXT.Text;
            historialMedicoVistaModelo.Tratamiento = TratamientoTXT.Text;
            historialMedicoVistaModelo.Observaciones = ObservacionesTXT.Text;
            historialMedicoVistaModelo.ID_Dueño_Cedula = DueñoCB.SelectedValue.ToString();
            historialMedicoVistaModelo.ID_Animal = int.Parse(MascotaCB.SelectedValue.ToString());
            historialMedicoVistaModelo.Fecha_Historial=DateTime.Parse(Fecha_HistoriaTXT.Text);
            historialMedicoVistaModelo.Est_Historial = 1;
            InsertarHistorialMedico();
            dtgHistorial.Rows.Clear();
            Listar();
            Limpiar();


        }
        public void Limpiar()
        {
            DiagnosticoTXT.Text = "";
            TratamientoTXT.Text = "";
            ObservacionesTXT.Text = "";
            Fecha_HistoriaTXT.Text = "";
            idAnimal.Text = "";
        }
        public void Listar()
        {
            listarHistorial = (List<HistorialMascotaDueño>)historialMedicoControlador.ListarHistorialActivos();
            foreach (HistorialMascotaDueño item in listarHistorial)
            {
                dtgHistorial.Rows.Add(new object[] {"",item.id_Historial,item.nombre_dueño,item.nombre_mascota,
                item.fecha,item.diagnostico,item.tratamiento,item.observacion});
            }

        }

        private void FormHistorialMedico_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinaria_FinalDataSet6.Historial_Medico' Puede moverla o quitarla según sea necesario.

            ListarDueños();
            ListarAnimales();
            Listar();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgHistorial.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    idAnimal.Text = dtgHistorial.Rows[indice].Cells["id_historial"].Value.ToString();
                    DiagnosticoTXT.Text = dtgHistorial.Rows[indice].Cells["diagnostico"].Value.ToString();
                    TratamientoTXT.Text = dtgHistorial.Rows[indice].Cells["tratamiento"].Value.ToString();
                    ObservacionesTXT.Text = dtgHistorial.Rows[indice].Cells["observacion"].Value.ToString();
                    DueñoCB.Text = dtgHistorial.Rows[indice].Cells["dueño"].Value.ToString();
                    MascotaCB.Text = dtgHistorial.Rows[indice].Cells["mascota"].Value.ToString();
                    Fecha_HistoriaTXT.Text = dtgHistorial.Rows[indice].Cells["fecha"].Value.ToString();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idAnimal.Text))
            {
                MessageBox.Show("El Id del historial no fue encontrado");
                return;
            }
            historialMedicoVistaModelo.ID_Historial = int.Parse(idAnimal.Text);
            historialMedicoVistaModelo.Diagnostico = DiagnosticoTXT.Text;
            historialMedicoVistaModelo.Tratamiento = TratamientoTXT.Text;
            historialMedicoVistaModelo.Observaciones = ObservacionesTXT.Text;
            historialMedicoVistaModelo.ID_Dueño_Cedula = DueñoCB.SelectedValue.ToString();
            historialMedicoVistaModelo.ID_Animal = int.Parse(MascotaCB.SelectedValue.ToString());
            historialMedicoVistaModelo.Fecha_Historial = DateTime.Parse(Fecha_HistoriaTXT.Text);
            historialMedicoVistaModelo.Est_Historial = 1;
            ModificarHistorial_Medico();
            dtgHistorial.Rows.Clear();
            Listar();
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idAnimal.Text))
            {
                MessageBox.Show("El Id del historial no fue encontrado");
                return;
            }

            var eliminacionHistorial = historialMedicoControlador.EliminarHistorial(int.Parse(idAnimal.Text));
            if (eliminacionHistorial)
            {
                MessageBox.Show("Historial eliminado correctamente");

            }
            else
            {
                MessageBox.Show("Error: Al elimnar historial");
            }
            dtgHistorial.Rows.Clear();
            Limpiar();
            Listar();
        }

        private void dtgHistorial_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
