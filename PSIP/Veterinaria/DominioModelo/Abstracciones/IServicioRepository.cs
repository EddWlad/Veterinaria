using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioModelo.Abstracciones
{
    public interface IServicioRepository : IBaseRepository<Servicios>
    {
        IEnumerable<Servicios> ListarServiciosActivos();
        bool ElminarServicio(int id);
    }
}
