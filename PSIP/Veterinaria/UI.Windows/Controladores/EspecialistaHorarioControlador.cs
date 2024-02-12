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
    public class EspecialistaHorarioControlador
    {
        private EspecialistaHorarioServicio ServicioEspecialistaHorario;
        public EspecialistaHorarioControlador()
        {
            this.ServicioEspecialistaHorario = new EspecialistaHorarioServicio();   
        }


        public bool InsertarEspecialistaHorario(EspecialistaHorarioVistaModelo EspecialistaHorarioVM)
        {
            try
            {
                Especialista_Horario EspecialistaHorarioDB = new Especialista_Horario();
              
                this.ServicioEspecialistaHorario.InsertarEspecialista_Horario(EspecialistaHorarioDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<Especialista_Horario> ListarEspecialista_HorarioActivos()
        {
            return ServicioEspecialistaHorario.ListarEspecialista_HorarioActivos();
        }
    }
}
