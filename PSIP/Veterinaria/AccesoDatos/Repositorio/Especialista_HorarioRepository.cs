using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class Especialista_HorarioRepository : BaseRpository<Especialista_Horario>, IEspecialista_HorarioRepository
    {
        public IEnumerable<Especialista_Horario> ListarEspecialista_HorarioActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var ListarEspecialista_Horario = from e in context.Especialista_Horario
                                                     where e.ID_Esp_Hora >= 0
                                       select e;
                    return ListarEspecialista_Horario.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NO se pudo insertar datos", ex);
            }
        }
    }
}
