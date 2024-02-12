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
    public class DueñoServicio
    {
        readonly IDueñoRepository dueñoRepository;
        public DueñoServicio()
        {
            this.dueñoRepository = new DueñoRepository();
        }
        public IEnumerable<Dueño> ListarDueño()
        {
            return this.dueñoRepository.GetAll();
        }
        public void InsertarDueño(Dueño dueño)
        {
            this.dueñoRepository.Add(dueño);
        }
        public void ModificarDueño(Dueño dueño)
        {
            this.dueñoRepository.Modify(dueño);
        }
        public IEnumerable<Dueño> ListarDueñoActivos()
        {
            return this.dueñoRepository.ListarDueñoActivos();
        }
        public bool EliminarCliente(string id)
        {
            return this.dueñoRepository.ElminarCliente(id);
        }
    }
}
