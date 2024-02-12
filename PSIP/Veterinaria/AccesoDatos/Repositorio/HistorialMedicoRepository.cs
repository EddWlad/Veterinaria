using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class HistorialMedicoRepository : BaseRpository<Historial_Medico>, IHistorialMedicoRepository
    {
        public bool ElminarHistorial(int id)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    // 1.- Buscar el cliente a actualizar
                    var historial = context.Historial_Medico.FirstOrDefault(c => c.ID_Historial == id);
                    if (historial != null)
                    {
                        // 2.- Actualizar los campos necesarios

                        historial.Est_Historial = 0;


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

        public IEnumerable<HistorialMascotaDueño> ListarHistorialActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    //2.- escribil la consulta
                    var historialAnimales = context.Historial_Medico
                    .Join(context.Dueño,
                        a => a.ID_Dueño_Cedula,
                        d => d.ID_Dueño_Cedula,
                       (historial, dueño) => new { historial, dueño })
                    .Join(context.Animales,
                        detalleMascota => detalleMascota.historial.ID_Dueño_Cedula,
                        animales => animales.ID_Dueño_Cedula,
                        (detalleMascota, animales) => new HistorialMascotaDueño
                        {
                            id_Historial = detalleMascota.historial.ID_Historial,
                            nombre_dueño = detalleMascota.dueño.Nombre_Dueño,
                            nombre_mascota = animales.Nombre,
                            fecha = (DateTime)detalleMascota.historial.Fecha_Historial,
                            diagnostico = detalleMascota.historial.Diagnostico,
                            tratamiento = detalleMascota.historial.Tratamiento,
                            observacion = detalleMascota.historial.Observaciones,
                            est_Historial = (int)detalleMascota.historial.Est_Historial

                        }).Where(p => p.est_Historial.Equals(1)).ToList();
                    //3.- retorno resultado
                    return historialAnimales.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registro.", ex);
            }
        }

        public IEnumerable<Historial_Medico> ListarHistorial_MedicoActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    var ListarHistorial_Medico = from e in context.Historial_Medico
                                                 where e.Est_Historial > 0
                                             select e;
                    return ListarHistorial_Medico.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("NO se pudo insertar datos", ex);
            }
        }
    }

}
