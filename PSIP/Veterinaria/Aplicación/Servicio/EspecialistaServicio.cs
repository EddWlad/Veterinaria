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
    public class EspecialistaServicio
    {
        readonly IEspecialistaRepository especialistaRepository;
        public EspecialistaServicio()
        {
            this.especialistaRepository = new EspecialistaRepository();
        }



        public IEnumerable<Especialista> ListarEspecialista()
        {
            return this.especialistaRepository.GetAll();
        }
        public void InsertarEspecialista(Especialista especialista)
        {
            this.especialistaRepository.Add(especialista);
        }
        public void ModificarEspecialista(Especialista especialista)
        {
            this.especialistaRepository.Modify(especialista);
        }
        public IEnumerable<Especialista> ListarEspecialistaActivos()
        {
            return this.especialistaRepository.ListarEspecialistaActivos();
        }
    }
}
