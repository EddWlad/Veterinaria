using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class ServiciosRepository : BaseRpository<Servicios>, IServicioRepository
    {
        public bool ElminarServicio(int id)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    // 1.- Buscar el cliente a actualizar
                    var servicio = context.Servicios.FirstOrDefault(c => c.ID_Servicio == id);
                    if (servicio != null)
                    {
                        // 2.- Actualizar los campos necesarios

                        servicio.Est_Serv = 0;


                        // 3.- Guardar los cambios en la base de datos
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                        throw new Exception("El valor de cliente es nulo");

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("No se pudo actualizar el registro del cliente.", ex);

            }
        }

        public IEnumerable<Servicios> ListarServiciosActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var ListarServicios = from e in context.Servicios
                                          where e.Est_Serv > 0
                                     select e;
                    return ListarServicios.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NO se pudo insertar datos", ex);
            }
        }
    }
}
