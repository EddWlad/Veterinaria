using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioModelo.Abstracciones
{
    public interface IHistorialMedicoRepository : IBaseRepository<Historial_Medico>
    {
        IEnumerable<Historial_Medico> ListarHistorial_MedicoActivos();
        
        IEnumerable<HistorialMascotaDueño> ListarHistorialActivos();
        bool ElminarHistorial(int id);
    }
}
