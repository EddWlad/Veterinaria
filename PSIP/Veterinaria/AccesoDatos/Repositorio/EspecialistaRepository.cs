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
        public bool ElminarEspecialista(string id)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    // 1.- Buscar el cliente a actualizar
                    var especialista = context.Especialista.FirstOrDefault(c => c.ID_Especialista_Cedula == id);
                    if (especialista != null)
                    {
                        // 2.- Actualizar los campos necesarios

                        especialista.Est_Espe = 0;


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

        public IEnumerable<EspecialistaServiciosEspecilista> EspecialistaActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    //2.- escribil la consulta
                    var especialistaServicios = context.Especialista
                    .Join(context.Servicios,
                        a => a.ID_Servicio,
                        d => d.ID_Servicio,
                       (especialista, servicio) => new EspecialistaServiciosEspecilista
                        {
                            id_especialista_cedula= especialista.ID_Especialista_Cedula,
                            nombre = especialista.Nombre_Espe,
                            apellido = especialista.Apellido_Espe,
                            telefono = especialista.Telefono_Espe,
                            email = especialista.Email_Espe,
                            especializacion = especialista.Especialización_Espe,
                            estado= (int)especialista.Est_Espe,
                            servicio = servicio.Nombre_Serv
                        }).Where(p => p.estado.Equals(1)).ToList();
                    //3.- retorno resultado
                    return especialistaServicios.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registro.", ex);
            }
        }

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
