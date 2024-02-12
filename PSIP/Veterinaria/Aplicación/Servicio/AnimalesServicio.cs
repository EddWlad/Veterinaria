using AccesoDatos.Repositorio;
using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación.Servicio
{
    public class AnimalesServicio
    {
        readonly IAnimalesRepository animalesRepository;
        public AnimalesServicio()
        {
            this.animalesRepository = new AnimalesRepository();
        }


        public IEnumerable<Animales> ListarAnimales()
        {
            return this.animalesRepository.GetAll();
        }
        public void InsertarAnimales(Animales animales)
        {
            this.animalesRepository.Add(animales);
        }
        public void ModificarAnimales(Animales animales)
        {
            this.animalesRepository.Modify(animales);
        }
        public IEnumerable<DueñoDescripcionAnimal> ListarAnimalesActivos()
        {
            return this.animalesRepository.ListarAnimalesActivos();
        }
        public bool EliminarAnimal(int id)
        {
            return this.animalesRepository.ElminarAnimal(id);
        }
    }
}
