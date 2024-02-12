using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class HorarioRepository : BaseRpository<Horario>, IHorarioRepository
    {
        public IEnumerable<Horario> ListarHorarioActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var ListarHorario = from e in context.Horario
                                        where e.ID_Horario >= 0
                                                 select e;
                    return ListarHorario.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NO se pudo insertar datos", ex);
            }
        }
    }
}
