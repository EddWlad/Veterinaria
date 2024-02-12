using Aplicación.Servicio;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.VistaModelo;

namespace UI.Windows.Controladores
{
    public class CitaControlador
    {
        private CitaServicio ServicioCita;
        public CitaControlador()
        {
            this.ServicioCita = new CitaServicio();
        }

        public bool InsertarCita(CitaVistaModelo CitaVM)
        {
            try
            {
                Cita citaDB = new Cita();
                citaDB.Fecha_Cita = CitaVM.Fecha_Cita;
                citaDB.ID_Animal = CitaVM.ID_Animal;
                citaDB.ID_Especialista_Cedula = CitaVM.ID_Especialista_Cedula;
                citaDB.ID_Servicio = CitaVM.ID_Servicio;
                citaDB.Fecha_Hora = CitaVM.Fecha_Hora;
                citaDB.ID_Dueño_Cedula = CitaVM.ID_Dueño_Cedula;
                //citaDB.Est_Cita = CitaVM.Est_Cita;
                this.ServicioCita.InsertarCita(citaDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Cita> ListarCita()
        {
            List<Cita> cita = new List<Cita>();
            try
            {
                cita = this.ServicioCita.ListarCita().ToList();
            }
            catch (Exception)
            {

            }
            return cita;
        }
        public IEnumerable<Cita> ListarCitaActivos()
        {
            return ServicioCita.ListarCitaActivos();
        }
        public bool ModificarCita(CitaVistaModelo CitaVM)
        {
            try
            {
                Cita citaDB = new Cita();
                citaDB.ID_Citas = CitaVM.ID_Citas;
                citaDB.Fecha_Cita = CitaVM.Fecha_Cita;
                citaDB.ID_Animal = CitaVM.ID_Animal;
                citaDB.ID_Especialista_Cedula = CitaVM.ID_Especialista_Cedula;
                citaDB.ID_Servicio = CitaVM.ID_Servicio;
                citaDB.Fecha_Hora = CitaVM.Fecha_Hora;
                citaDB.ID_Dueño_Cedula = CitaVM.ID_Dueño_Cedula;
                //citaDB.Est_Cita = CitaVM.Est_Cita;
                this.ServicioCita.ModificarCita(citaDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
