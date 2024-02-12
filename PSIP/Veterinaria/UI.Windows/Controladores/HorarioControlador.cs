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
    public class HorarioControlador
    {
        private HorarioServicio ServicioHorario;
        public HorarioControlador()
        {
            this.ServicioHorario = new HorarioServicio();
        }


        public bool InsertarHorario(HorarioVistaModelo HorarioVM)
        {
            try
            {
                Horario HorarioDB = new Horario();
                HorarioDB.ID_Cita = HorarioVM.ID_Cita;
                this.ServicioHorario.InsertarHorario(HorarioDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Horario> ListarHorario()
        {
            List<Horario> horario = new List<Horario>();
            try
            {
                horario = this.ServicioHorario.ListarHorario().ToList();
            }
            catch (Exception)
            {

            }
            return horario;
        }
        public IEnumerable<Horario> ListarHorarioActivos()
        {
            return ServicioHorario.ListarHorarioActivos();
        }
    }
}
