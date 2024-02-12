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
    public class CitaServicio
    {
        readonly ICitaRepository citaRepository;
        public CitaServicio()
        {
            this.citaRepository = new CitaRepository();
        }
        public IEnumerable<Cita> ListarCita()
        {
            return this.citaRepository.GetAll();
        }
        public void InsertarCita(Cita cita)
        {
            this.citaRepository.Add(cita);
        }
        public void ModificarCita(Cita cita)
        {
            this.citaRepository.Modify(cita);
        }
        public IEnumerable<Cita> ListarCitaActivos()
        {
            return this.citaRepository.ListarCitaActivos();
        }
    }
}
