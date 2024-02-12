using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class SexoRepository : BaseRpository<Sexo>, ISexoRepository
    {
        public IEnumerable<Sexo> ListarSexoActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var ListarSexo = from e in context.Sexo
                                     where e.estado == true
                                     select e;

                    return ListarSexo.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NO se pudo insertar datos", ex);
            }
        }
    }
}
