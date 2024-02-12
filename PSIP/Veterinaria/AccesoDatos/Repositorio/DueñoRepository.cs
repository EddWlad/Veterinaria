using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class DueñoRepository : BaseRpository<Dueño>, IDueñoRepository
    {
        public bool ElminarCliente(string id)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    // 1.- Buscar el cliente a actualizar
                    var cliente = context.Dueño.FirstOrDefault(c => c.ID_Dueño_Cedula == id);
                    if (cliente != null)
                    {
                        // 2.- Actualizar los campos necesarios

                        cliente.Est_Dueño = 0;


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

        public List<Dueño> ListarDueñoActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var ListarDueño = from e in context.Dueño
                                      where e.Est_Dueño == 1
                                       select e;
                    return ListarDueño.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NO se pudo insertar datos", ex);
            }
        }
    }
}
