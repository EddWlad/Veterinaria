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
    public class HorarioServicio
    {
        readonly IHorarioRepository horarioRepository;
        public HorarioServicio()
        {
            this.horarioRepository = new HorarioRepository();
        }


        public IEnumerable<Horario> ListarHorario()
        {
            return this.horarioRepository.GetAll();
        }
        public void InsertarHorario(Horario horario)
        {
            this.horarioRepository.Add(horario);
        }
        public void ModificarHorario(Horario horario)
        {
            this.horarioRepository.Modify(horario);
        }
        public IEnumerable<Horario> ListarHorarioActivos()
        {
            return this.horarioRepository.ListarHorarioActivos();
        }
      
    }
}
