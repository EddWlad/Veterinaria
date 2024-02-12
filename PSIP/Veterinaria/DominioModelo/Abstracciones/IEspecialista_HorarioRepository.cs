using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioModelo.Abstracciones
{
    public interface IEspecialista_HorarioRepository : IBaseRepository<Especialista_Horario>
    {
        IEnumerable<Especialista_Horario> ListarEspecialista_HorarioActivos();
    }
}
