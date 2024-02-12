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
    public class HistorialMedicoControlador
    {
        private HistorialMedicoServicio ServicioHistorialMedico;
        public HistorialMedicoControlador()
        {
            this.ServicioHistorialMedico = new HistorialMedicoServicio();
        }

        public bool InsertarHistorialMedico(HistorialMedicoVistaModelo HistorialMedicoVM)
        {
            try
            {
                Historial_Medico HistorialMedicoDB = new Historial_Medico();
                HistorialMedicoDB.Fecha_Historial = HistorialMedicoVM.Fecha_Historial;
                HistorialMedicoDB.Diagnostico = HistorialMedicoVM.Diagnostico;
                HistorialMedicoDB.Tratamiento = HistorialMedicoVM.Tratamiento;
                HistorialMedicoDB.Observaciones = HistorialMedicoVM.Observaciones;
                HistorialMedicoDB.ID_Dueño_Cedula = HistorialMedicoVM.ID_Dueño_Cedula;
                HistorialMedicoDB.ID_Animal = HistorialMedicoVM.ID_Animal;
                HistorialMedicoDB.Est_Historial = HistorialMedicoVM.Est_Historial;
                ServicioHistorialMedico.InsertarHistorial_Medico(HistorialMedicoDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Historial_Medico> ListarHistorial_Medico()
        {
            List<Historial_Medico> historialMedico = new List<Historial_Medico>();
            try
            {
                historialMedico = this.ServicioHistorialMedico.ListarHistorial_Medico().ToList();
            }
            catch (Exception)
            {

            }
            return historialMedico;
        }
        public IEnumerable<Historial_Medico> ListarHistorial_MedicoActivos()
        {
            return ServicioHistorialMedico.ListarHistorial_MedicoActivos();
        }
        
        public IEnumerable<HistorialMascotaDueño> ListarHistorialActivos()
        {
            return ServicioHistorialMedico.ListarHistorialActivos();
        }
        public bool ModificarHistorial_Medico(HistorialMedicoVistaModelo historialVM)
        {
            try
            {
                Historial_Medico HistorialDB = new Historial_Medico();
                HistorialDB.ID_Historial = historialVM.ID_Historial;
                HistorialDB.Fecha_Historial = historialVM.Fecha_Historial;
                HistorialDB.Diagnostico = historialVM.Diagnostico;
                HistorialDB.Tratamiento = historialVM.Tratamiento;
                HistorialDB.Observaciones = historialVM.Observaciones;
                HistorialDB.ID_Dueño_Cedula = historialVM.ID_Dueño_Cedula;
                HistorialDB.ID_Animal = historialVM.ID_Animal;
                HistorialDB.Est_Historial = historialVM.Est_Historial;
                ServicioHistorialMedico.ModificarHistorial_Medico(HistorialDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EliminarHistorial(int id)
        {
            return ServicioHistorialMedico.EliminarHistorial(id);
        }
    }
}
