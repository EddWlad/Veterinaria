using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class RazaRepository : BaseRpository<Raza>, IRazaRepository
    {
        public bool ElminarRaza(int id)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    // 1.- Buscar el cliente a actualizar
                    var raza = context.Raza.FirstOrDefault(c => c.ID_Raza == id);
                    if (raza != null)
                    {
                        // 2.- Actualizar los campos necesarios

                        raza.Est_Raza = 0;


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

        public IEnumerable<Raza> ListarRazaActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var ListarRaza = from e in context.Raza
                                     where e.Est_Raza > 0
                                     select e;
                    return ListarRaza.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NO se pudo insertar datos", ex);
            }
        }
    }
}
