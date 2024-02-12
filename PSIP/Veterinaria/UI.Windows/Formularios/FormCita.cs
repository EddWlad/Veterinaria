using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UI.Windows.Controladores;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{
    public partial class FormCita : Form
    {
        CitaControlador citaControlador;
        CitaVistaModelo citaVistaModelo;
        DueñoControlador dueñocontrolador;
        AnimalesControlador animalcontrolador;
        ServiciosControlador servicioscontrolador;
        EspecialistaControlador especialistaControlador;
        HorarioControlador horarioControlador;
        HorarioVistaModelo horariovistamodelo;
        EspecialistaHorarioControlador especialistaHorarioControlador;
        EspecialistaHorarioVistaModelo especialistaHorarioVistaModelo;
        public FormCita()
        {
            InitializeComponent();
            citaVistaModelo = new CitaVistaModelo();
            citaControlador = new CitaControlador();
            dueñocontrolador = new DueñoControlador();
            animalcontrolador = new AnimalesControlador();
            servicioscontrolador = new ServiciosControlador();
            especialistaControlador = new EspecialistaControlador();
            horarioControlador = new HorarioControlador();
            horariovistamodelo = new HorarioVistaModelo();
            especialistaHorarioControlador = new EspecialistaHorarioControlador();
            especialistaHorarioVistaModelo = new EspecialistaHorarioVistaModelo();
        }
        private void InsertarCita()

        {

            if (citaControlador.InsertarCita(citaVistaModelo))
            {
                MessageBox.Show("Mascota insertada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al insertar Mascota.");
            }
        }

        private void InsertarHorario()

        {

            if (horarioControlador.InsertarHorario(horariovistamodelo))
            {
               
            }
            else
            {
                MessageBox.Show("Error: Al insertar hora.");
            }
        }


        private void InsertarEspecialistaHorario()

        {

            if (especialistaHorarioControlador.InsertarEspecialistaHorario(especialistaHorarioVistaModelo))
            {
               
            }
            else
            {
                MessageBox.Show("Error: Al insertar Hora especialista.");
            }
        }

        private void ModificarCita()

        {

            if (citaControlador.ModificarCita(citaVistaModelo))
            {
                MessageBox.Show("Cita Modificada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al Modificar Cita.");
            }
        }


        private void DueñoCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Especialista_Click(object sender, EventArgs e)
        {
            TimeSpan outHora;
            citaVistaModelo.Fecha_Cita = DateTime.Parse(Fecha_CitaTXT.Text);
            citaVistaModelo.ID_Animal = int.Parse(MascotaCB.SelectedValue.ToString());
            citaVistaModelo.ID_Especialista_Cedula = EspecialistaCB.SelectedValue.ToString();
            citaVistaModelo.ID_Servicio = int.Parse(ServicioCB.SelectedValue.ToString());
            if (TimeSpan.TryParse(HORATXT.Text, out outHora))
            {
                citaVistaModelo.Fecha_Hora = outHora;
            }
            else
            {
                // Manejar el caso en que la conversión no sea exitosa (por ejemplo, mostrar un mensaje de error)
                MessageBox.Show("Formato de hora no válido.");
            }
            citaVistaModelo.ID_Dueño_Cedula = DueñoCB.SelectedValue.ToString();
            citaVistaModelo.Est_Cita = 1;
            InsertarCita();
            horariovistamodelo.ID_Cita = citaVistaModelo.ID_Citas;
            InsertarHorario();
            especialistaHorarioVistaModelo.ID_Especialista_Cedula = EspecialistaCB.SelectedValue.ToString();
            especialistaHorarioVistaModelo.ID_Horario = horariovistamodelo.ID_Horario;
            InsertarEspecialistaHorario();

            Fecha_CitaTXT.Text = "";
            MascotaCB.Text = "";
            EspecialistaCB.Text = "";
            ServicioCB.Text = "";
            HORATXT.Text = "";
            DueñoCB.Text = "";
            idAnimal.Text = "";

            dataGridView1.DataSource = citaControlador.ListarCitaActivos();
        }
        private void ListarDueños()
        {
            //var nombredueño = dueñocontrolador.ListarDueño().Select(x => new DueñoCBVistaModelo { ID_Dueño_Cedula = x.ID_Dueño_Cedula, Nombre_Dueño = $"{x.Nombre_Dueño} {x.Apellido_Dueño}" }).ToList();

            //DueñoCB.DataSource = nombredueño;
            DueñoCB.DisplayMember = "Nombre_Dueño";
            DueñoCB.ValueMember = "ID_Dueño_Cedula";
        }
        private void ListarAnimales()
        {

            MascotaCB.DataSource = animalcontrolador.ListarAnimalesActivos();
            MascotaCB.DisplayMember = "Nombre";
            MascotaCB.ValueMember = "ID_Animal";
        }
        private void ListarServicios()
        {

            ServicioCB.DataSource = servicioscontrolador.ListarServiciosActivos();
            ServicioCB.DisplayMember = "Nombre_Serv";
            ServicioCB.ValueMember = "ID_Servicio";
        }
        private void ListarEspecialista()
        {

            var nombreespecialista = especialistaControlador.ListarEspecialista().Select(x => new EspecialistaCBVistaModelo { ID_Especialista_Cedula = x.ID_Especialista_Cedula, Nombre_Espe = $"{x.Nombre_Espe} {x.Apellido_Espe}" }).ToList();

            EspecialistaCB.DataSource = nombreespecialista;
            EspecialistaCB.DisplayMember = "Nombre_Espe";
            EspecialistaCB.ValueMember = "ID_Especialista_Cedula";
        }
        private void FormCita_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinaria_FinalDataSet2.Cita' Puede moverla o quitarla según sea necesario.

            dataGridView1.DataSource = citaControlador.ListarCitaActivos();
            ListarDueños();
           
            ListarAnimales();
            ListarServicios();
            ListarEspecialista();
        }
       
        private void MascotaCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ServicioCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EspecialistaCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HORATXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnselec")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    idAnimal.Text = dataGridView1.Rows[indice].Cells["IDCitas"].Value.ToString();
                    DueñoCB.Text = dataGridView1.Rows[indice].Cells["iDDueño"].Value.ToString();
                    MascotaCB.Text = dataGridView1.Rows[indice].Cells["iDAnimal1"].Value.ToString();
                    ServicioCB.Text = dataGridView1.Rows[indice].Cells["iDServicioD"].Value.ToString();
                    EspecialistaCB.Text = dataGridView1.Rows[indice].Cells["iDEspecialistaC"].Value.ToString();
                    Fecha_CitaTXT.Text = dataGridView1.Rows[indice].Cells["fechaCita"].Value.ToString();
                    HORATXT.Text = dataGridView1.Rows[indice].Cells["fechaHora"].Value.ToString();
                    
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TimeSpan outHora;
            if (string.IsNullOrEmpty(idAnimal.Text))
            {
                MessageBox.Show("El Id de la cita no fue encontrado");
                return;
            }
            citaVistaModelo.ID_Citas = int.Parse(idAnimal.Text);
            citaVistaModelo.Fecha_Cita = DateTime.Parse(Fecha_CitaTXT.Text);
            citaVistaModelo.ID_Animal = int.Parse(MascotaCB.SelectedValue.ToString());
            citaVistaModelo.ID_Especialista_Cedula = EspecialistaCB.SelectedValue.ToString();
            citaVistaModelo.ID_Servicio = int.Parse(ServicioCB.SelectedValue.ToString());
            if (TimeSpan.TryParse(HORATXT.Text, out outHora))
            {
                citaVistaModelo.Fecha_Hora = outHora;
            }
            else
            {
                // Manejar el caso en que la conversión no sea exitosa (por ejemplo, mostrar un mensaje de error)
                MessageBox.Show("Formato de hora no válido.");
            }
            citaVistaModelo.ID_Dueño_Cedula = DueñoCB.SelectedValue.ToString();
            citaVistaModelo.Est_Cita = 1;
            ModificarCita();
            dataGridView1.DataSource = citaControlador.ListarCitaActivos();
            Fecha_CitaTXT.Text = "";
            MascotaCB.Text = "";
            EspecialistaCB.Text = "";
            ServicioCB.Text = "";
            HORATXT.Text = "";
            DueñoCB.Text = "";
            idAnimal.Text = "";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            TimeSpan outHora;
            if (string.IsNullOrEmpty(idAnimal.Text))
            {
                MessageBox.Show("El Id de la cita no fue encontrado");
                return;
            }
            citaVistaModelo.ID_Citas = int.Parse(idAnimal.Text);
            citaVistaModelo.Fecha_Cita = DateTime.Parse(Fecha_CitaTXT.Text);
            citaVistaModelo.ID_Animal = int.Parse(MascotaCB.SelectedValue.ToString());
            citaVistaModelo.ID_Especialista_Cedula = EspecialistaCB.SelectedValue.ToString();
            citaVistaModelo.ID_Servicio = int.Parse(ServicioCB.SelectedValue.ToString());
            if (TimeSpan.TryParse(HORATXT.Text, out outHora))
            {
                citaVistaModelo.Fecha_Hora = outHora;
            }
            else
            {
                // Manejar el caso en que la conversión no sea exitosa (por ejemplo, mostrar un mensaje de error)
                MessageBox.Show("Formato de hora no válido.");
            }
            citaVistaModelo.ID_Dueño_Cedula = DueñoCB.SelectedValue.ToString();
            citaVistaModelo.Est_Cita = 0;
            ModificarCita();
            dataGridView1.DataSource = citaControlador.ListarCitaActivos();
            Fecha_CitaTXT.Text = "";
            MascotaCB.Text = "";
            EspecialistaCB.Text = "";
            ServicioCB.Text = "";
            HORATXT.Text = "";
            DueñoCB.Text = "";
            idAnimal.Text = "";
        }
    }
}
