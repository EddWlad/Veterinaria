using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Repositorio
{
    public class AnimalesRepository : BaseRpository<Animales>, IAnimalesRepository
    {
        public bool ElminarAnimal(int id)
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    // 1.- Buscar el cliente a actualizar
                    var animales = context.Animales.FirstOrDefault(c => c.ID_Animal == id);
                    if (animales != null)
                    {
                        // 2.- Actualizar los campos necesarios

                        animales.Est_Animal = 0;


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

        //public IEnumerable<Animales> ListarAnimalesActivos()
        // {
        // try
        // {
        // using (var context = new Veterinaria_FinalEntities())
        //{
        // var ListarAnimales = from e in context.Animales
        //where e.Est_Animal > 0
        // select e;
        //return ListarAnimales.ToList();
        //}
        // }
        // catch (Exception ex)
        //{
        // throw new Exception("NO se pudo insertar datos", ex);
        // }
        //}

        public IEnumerable<DueñoDescripcionAnimal> ListarAnimalesActivos()
        {
            try
            {
                using (var context = new Veterinaria_FinalEntities())
                {
                    //2.- escribil la consulta
                    var clientesAnimales = context.Animales
                    .Join(context.Dueño,
                        a => a.ID_Dueño_Cedula,
                        d => d.ID_Dueño_Cedula,
                       (animal, dueño) => new { animal, dueño })
                    .Join(context.Especie,
                        detalleMascota => detalleMascota.animal.ID_Especie,
                        especie => especie.ID_Especie,
                        (detalleMascota, especie) => new { detalleMascota, especie })
                    .Join(context.Raza,
                        descripMascota => descripMascota.detalleMascota.animal.ID_Raza,
                        raza => raza.ID_Raza,
                        (descripMascota, raza) => new { descripMascota, raza })
                    .Join(context.Sexo,
                        datosMascota => datosMascota.descripMascota.detalleMascota.animal.ID_Sexo,
                        sexo => sexo.ID_Sexo,
                        (datosMascota, sexo) => new DueñoDescripcionAnimal
                        {
                            id_Animal = datosMascota.descripMascota.detalleMascota.animal.ID_Animal,
                            nombre_dueño = datosMascota.descripMascota.detalleMascota.dueño.Nombre_Dueño,
                            nombre_mascota = datosMascota.descripMascota.detalleMascota.animal.Nombre,
                            fecha_nacimiento = (DateTime)datosMascota.descripMascota.detalleMascota.animal.Fecha_Nacimiento,
                            especie = datosMascota.descripMascota.especie.Nom_Especie,
                            raza = datosMascota.raza.Nombre_Raza,
                            sexo = sexo.Sexo1,
                            est_Animal = (int)datosMascota.descripMascota.detalleMascota.animal.Est_Animal

                        }).Where(p => p.est_Animal.Equals(1)).ToList();
                    //3.- retorno resultado
                    return clientesAnimales.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron recuperar los registro.", ex);
            }
        }
    }
}
