using System;
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
            dataGridView2.DataSource = especialistaControlador.ListarEspecialistaActivos();

            Cedula_Especialista.Text = "";
            Nombre_Especialista.Text = "";
            Apellido_Especialista.Text = "";
            Telefono_Especialista.Text = "";
            Email_Especialista.Text = "";
            Especialiazacion_Especialista.Text = "";
         
            ServicioCB.Text = "";

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

            dataGridView2.DataSource = especialistaControlador.ListarEspecialistaActivos();
            ListarServicios();
        
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "btnselec")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    Cedula_Especialista.Text = dataGridView2.Rows[indice].Cells["iDE"].Value.ToString();
                    Nombre_Especialista.Text = dataGridView2.Rows[indice].Cells["nombreE"].Value.ToString();
                    Apellido_Especialista.Text = dataGridView2.Rows[indice].Cells["apellidoE"].Value.ToString();
                    Telefono_Especialista.Text = dataGridView2.Rows[indice].Cells["telefonoE"].Value.ToString();
                    Email_Especialista.Text = dataGridView2.Rows[indice].Cells["emailE"].Value.ToString();
                    Especialiazacion_Especialista.Text = dataGridView2.Rows[indice].Cells["especializaciónE"].Value.ToString();
                    ServicioCB.Text = dataGridView2.Rows[indice].Cells["IDServicio"].Value.ToString();
                }
            }

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
            dataGridView2.DataSource = especialistaControlador.ListarEspecialistaActivos();

            Cedula_Especialista.Text = "";
            Nombre_Especialista.Text = "";
            Apellido_Especialista.Text = "";
            Telefono_Especialista.Text = "";
            Email_Especialista.Text = "";
            Especialiazacion_Especialista.Text = "";
            ServicioCB.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
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
            especialistaVistaModelo.Est_Espe = 0;
            especialistaVistaModelo.ID_Servicio = int.Parse(ServicioCB.SelectedValue.ToString());
            ModificarEspecialista();
            dataGridView2.DataSource = especialistaControlador.ListarEspecialistaActivos();

            Cedula_Especialista.Text = "";
            Nombre_Especialista.Text = "";
            Apellido_Especialista.Text = "";
            Telefono_Especialista.Text = "";
            Email_Especialista.Text = "";
            Especialiazacion_Especialista.Text = "";
            ServicioCB.Text = "";
        }
    }
}
