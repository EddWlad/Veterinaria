using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class CitaRepository : BaseRpository<Cita>, ICitaRepository
    {
        public IEnumerable<Cita> ListarCitaActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var ListarCita = from e in context.Cita
                                       where e.Est_Cita == true
                                       select e;
                    return ListarCita.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NO se pudo insertar datos", ex);
            }
        }
    }
}
