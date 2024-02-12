using AccesoDatos.Repositorio;
using DominioModelo.Abstracciones;
using DominioModelo.Entidades;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación.Servicio
{
    public class EspecieServicio
    {
        readonly IEspecieRepository especieRepository;
        public EspecieServicio()
        {
            this.especieRepository = new EspecieRepository();
        }
        public IEnumerable<Especie> ListarEspecie()
        {
            return this.especieRepository.GetAll();
        }
        public void InsertarEspecie(Especie especie)
        {
            this.especieRepository.Add(especie);
        }
        public void ModificarEspecie(Especie especie)
        {
            this.especieRepository.Modify(especie);
        }
        public IEnumerable<Especie> ListarEspecieActivos()
        {
            return this.especieRepository.ListarEspecieActivos();
        }
        public bool EliminarEspecie(int id)
        {
            return this.especieRepository.ElminarEspecie(id);
        }
    }
}
