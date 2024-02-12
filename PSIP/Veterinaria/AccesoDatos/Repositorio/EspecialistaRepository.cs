using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class EspecialistaRepository : BaseRpository<Especialista>, IEspecialistaRepository
    {
        public IEnumerable<Especialista> ListarEspecialistaActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var ListarEspecialista = from e in context.Especialista
                                         where e.Est_Espe > 0
                                         select e;
                    return ListarEspecialista.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NO se pudo insertar datos", ex);
            }
        }
    }
}
