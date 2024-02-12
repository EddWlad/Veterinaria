using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioModelo.Abstracciones
{
    public interface IEspecieRepository : IBaseRepository<Especie>
    {
        IEnumerable<Especie> ListarEspecieActivos();
        bool ElminarEspecie(int id);
    }
}
