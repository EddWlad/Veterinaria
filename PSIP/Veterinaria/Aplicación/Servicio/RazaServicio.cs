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
    public class RazaServicio
    {
        readonly IRazaRepository razaRepository;
        public RazaServicio()
        {
            this.razaRepository = new RazaRepository();
        }


        public IEnumerable<Raza> ListarRaza()
        {
            return this.razaRepository.GetAll();
        }
        public void InsertarRaza(Raza raza)
        {
            this.razaRepository.Add(raza);
        }
        public void ModificarRaza(Raza raza)
        {
            this.razaRepository.Modify(raza);
        }
        public IEnumerable<Raza> ListarRazaActivos()
        {
            return this.razaRepository.ListarRazaActivos();
        }
        public bool EliminarRaza(int id)
        {
            return this.razaRepository.ElminarRaza(id);
        }
    }
}
