using AccesoDatos.Repositorio;
using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación.Servicio
{
    public class EspecialistaHorarioServicio
    {
        readonly IEspecialista_HorarioRepository especialista_Horario;
        public EspecialistaHorarioServicio()
        {
            this.especialista_Horario = new Especialista_HorarioRepository();
        }
        public IEnumerable<Especialista_Horario> ListarEspecialista_Horario()
        {
            return this.especialista_Horario.GetAll();
        }
        public void InsertarEspecialista_Horario(Especialista_Horario especialista_Horario)
        {
            this.especialista_Horario.Add(especialista_Horario);
        }
        public void ModificarEspecialista_Horario(Especialista_Horario especialista_Horario)
        {
            this.especialista_Horario.Modify(especialista_Horario);
        }
        public IEnumerable<Especialista_Horario> ListarEspecialista_HorarioActivos()
        {
            return this.especialista_Horario.ListarEspecialista_HorarioActivos();
        }
    }
}
