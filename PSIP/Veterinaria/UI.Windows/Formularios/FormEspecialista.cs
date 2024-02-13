using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI.Windows.Controladores;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class v : Form
    {
        EspecialistaControlador especialistaControlador;
        EspecialistaVistaModelo especialistaVistaModelo;
        ServiciosControlador servicioscontrolador;
        List<EspecialistaServiciosEspecilista> listarEspecialista;
        public v()
        {
            InitializeComponent();
            especialistaVistaModelo = new EspecialistaVistaModelo();
            especialistaControlador = new EspecialistaControlador();
            servicioscontrolador = new ServiciosControlador();
        }
        private void InsertarEspecialista()

        {

            if (especialistaControlador.InsertarEspecialista(especialistaVistaModelo))
            {
                MessageBox.Show("Especialista insertado correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al insertar Especialista.");
            }
        }
        private void ModificarEspecialista()

        {

            if (especialistaControlador.ModificarEspecialista(especialistaVistaModelo))
            {
                MessageBox.Show("Especialista Modificada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al Modificar Especialista.");
            }
        }

        private void Guardar_Especialista_Click(object sender, EventArgs e)
        {
            especialistaVistaModelo.ID_Especialista_Cedula = Cedula_Especialista.Text;
            especialistaVistaModelo.Nombre_Espe = Nombre_Especialista.Text;
            especialistaVistaModelo.Apellido_Espe = Apellido_Especialista.Text;
            especialistaVistaModelo.Telefono_Espe = Telefono_Especialista.Text;
            especialistaVistaModelo.Email_Espe = Email_Especialista.Text;
            especialistaVistaModelo.Especialización_Espe = Especialiazacion_Especialista.Text;
            especialistaVistaModelo.Est_Espe = 1;
            especialistaVistaModelo.ID_Servicio = int.Parse(ServicioCB.SelectedValue.ToString());
            InsertarEspecialista();
            dtgEspecialista.Rows.Clear();
            Listar();
            Limpiar();

        }
        public void Limpiar()
        {
            Cedula_Especialista.Text = "";
            Nombre_Especialista.Text = "";
            Apellido_Especialista.Text = "";
            Telefono_Especialista.Text = "";
            Email_Especialista.Text = "";
            Especialiazacion_Especialista.Text = "";
        }
        public void Listar()
        {
            listarEspecialista = (List<EspecialistaServiciosEspecilista>)especialistaControlador.EspecialistasActivos();
            foreach (EspecialistaServiciosEspecilista item in listarEspecialista)
            {
                dtgEspecialista.Rows.Add(new object[] {"",item.id_especialista_cedula,item.nombre,item.apellido,item.telefono,
                item.email,item.especializacion, item.servicio});
            }
        }

        private void ListarServicios()
        {

            ServicioCB.DataSource = servicioscontrolador.ListarServiciosActivos();
            ServicioCB.DisplayMember = "Nombre_Serv";
            ServicioCB.ValueMember = "ID_Servicio";
        }
        private void v_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinaria_FinalDataSet8.Especialista' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'veterinaria_FinalDataSet5.Especialista' Puede moverla o quitarla según sea necesario.
            Listar();
            ListarServicios();
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cedula_Especialista.Text))
            {
                MessageBox.Show("la cedula del especialista no fue encontrado");
                return;
            }
            especialistaVistaModelo.ID_Especialista_Cedula = Cedula_Especialista.Text;
            especialistaVistaModelo.Nombre_Espe = Nombre_Especialista.Text;
            especialistaVistaModelo.Apellido_Espe = Apellido_Especialista.Text;
            especialistaVistaModelo.Telefono_Espe = Telefono_Especialista.Text;
            especialistaVistaModelo.Email_Espe = Email_Especialista.Text;
            especialistaVistaModelo.Especialización_Espe = Especialiazacion_Especialista.Text;
            especialistaVistaModelo.Est_Espe = 1;
            especialistaVistaModelo.ID_Servicio = int.Parse(ServicioCB.SelectedValue.ToString());
            ModificarEspecialista();
            dtgEspecialista.Rows.Clear();
            Listar();
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Cedula_Especialista.Text))
            {
                MessageBox.Show("El Id del historial no fue encontrado");
                return;
            }

            var eliminacionEspecialista = especialistaControlador.EliminarEspecialista(Cedula_Especialista.Text);
            if (eliminacionEspecialista)
            {
                MessageBox.Show("Especialista eliminado correctamente");

            }
            else
            {
                MessageBox.Show("Error: Al elimnar especialista");
            }
            dtgEspecialista.Rows.Clear();
            Limpiar();
            Listar();
        }

        private void dtgEspecialista_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dtgEspecialista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgEspecialista.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    Cedula_Especialista.Text = dtgEspecialista.Rows[indice].Cells["cedula"].Value.ToString();
                    Nombre_Especialista.Text = dtgEspecialista.Rows[indice].Cells["nombre"].Value.ToString();
                    Apellido_Especialista.Text = dtgEspecialista.Rows[indice].Cells["apellido"].Value.ToString();
                    Telefono_Especialista.Text = dtgEspecialista.Rows[indice].Cells["telefono"].Value.ToString();
                    Email_Especialista.Text = dtgEspecialista.Rows[indice].Cells["email"].Value.ToString();
                    Especialiazacion_Especialista.Text = dtgEspecialista.Rows[indice].Cells["especializacion"].Value.ToString();
                    ServicioCB.Text = dtgEspecialista.Rows[indice].Cells["servicio"].Value.ToString();
                }
            }
        }
    }
}
