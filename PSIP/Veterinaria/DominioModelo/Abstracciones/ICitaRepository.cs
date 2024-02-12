using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioModelo.Abstracciones
{
    public interface ICitaRepository : IBaseRepository<Cita>
    {
        IEnumerable<Cita> ListarCitaActivos();
    }
}
