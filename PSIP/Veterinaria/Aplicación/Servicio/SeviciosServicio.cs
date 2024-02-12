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
    public class SeviciosServicio
    {
        readonly IServicioRepository servicioRepository;
        public SeviciosServicio()
        {
            this.servicioRepository = new ServiciosRepository();
        }



        public IEnumerable<Servicios> ListarServicios()
        {
            return this.servicioRepository.GetAll();
        }
        public void InsertarServicios(Servicios servicios)
        {
            this.servicioRepository.Add(servicios);
        }
        public void ModificarServicios(Servicios servicios)
        {
            this.servicioRepository.Modify(servicios);
        }
        public IEnumerable<Servicios> ListarServiciosActivos()
        {
            return this.servicioRepository.ListarServiciosActivos();
        }
        public bool EliminarServicio(int id)
        {
            return this.servicioRepository.ElminarServicio(id);
        }
    }
}
