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
    public class SexoServicio
    {
        readonly ISexoRepository sexoRepository;
        public SexoServicio()
        {
            this.sexoRepository = new SexoRepository();
        }


        public IEnumerable<Sexo> ListarSexo()
        {
            return this.sexoRepository.GetAll();
        }
        public void InsertarRaza(Sexo sexo)
        {
            this.sexoRepository.Add(sexo);
        }
        public void ModificarRaza(Sexo sexo)
        {
            this.sexoRepository.Modify(sexo);
        }
        public IEnumerable<Sexo> ListarRazaActivos()
        {
            return this.sexoRepository.ListarSexoActivos();
        }
        //public bool EliminarSexo(int id)
        //{
           // return this.sexoRepository.(id);
       // }
    }
}
