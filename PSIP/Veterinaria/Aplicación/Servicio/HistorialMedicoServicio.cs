using AccesoDatos.Repositorio;
using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación.Servicio
{
    public class HistorialMedicoServicio
    {
        readonly IHistorialMedicoRepository historialMedicoRepository;
        public HistorialMedicoServicio()
        {
            this.historialMedicoRepository = new HistorialMedicoRepository();
        }


        public IEnumerable<Historial_Medico> ListarHistorial_Medico()
        {
            return this.historialMedicoRepository.GetAll();
        }
        public void InsertarHistorial_Medico(Historial_Medico historial_Medico)
        {
            this.historialMedicoRepository.Add(historial_Medico);
        }
        public void ModificarHistorial_Medico(Historial_Medico historial_Medico)
        {
            this.historialMedicoRepository.Modify(historial_Medico);
        }
        public IEnumerable<Historial_Medico> ListarHistorial_MedicoActivos()
        {
            return this.historialMedicoRepository.ListarHistorial_MedicoActivos();
        }
        public IEnumerable<HistorialMascotaDueño> ListarHistorialActivos()
        {
            return this.historialMedicoRepository.ListarHistorialActivos();
        }
        public bool EliminarHistorial(int id)
        {
            return this.historialMedicoRepository.ElminarHistorial(id);
        }
    }
}
