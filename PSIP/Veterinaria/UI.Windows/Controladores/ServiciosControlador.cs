using Aplicación.Servicio;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.VistaModelo;

namespace UI.Windows.Controladores
{
    public class ServiciosControlador
    {
        private SeviciosServicio ServicioServicios;
        public ServiciosControlador()
        {
            this.ServicioServicios = new SeviciosServicio();
        }



        public bool InsertarServicios(ServiciosVistaModelo ServiciosVM)
        {
            try
            {
                Servicios ServiciosDB = new Servicios();
                ServiciosDB.Nombre_Serv = ServiciosVM.Nombre_Serv;
                ServiciosDB.Descripcion_Serv = ServiciosVM.Descripcion_Serv;
                ServiciosDB.Est_Serv = ServiciosVM.Est_Serv;
                this.ServicioServicios.InsertarServicios(ServiciosDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Servicios> ListarServiciosActivos()
        {
            return ServicioServicios.ListarServiciosActivos();
        }

        public bool ModificarServicio(ServiciosVistaModelo servicioVM)
        {
            Servicios servicioDB = new Servicios();
            try
            {
                
                servicioDB.ID_Servicio = servicioVM.ID_Servicio;
                servicioDB.Nombre_Serv = servicioVM.Nombre_Serv;
                servicioDB.Descripcion_Serv = servicioVM.Descripcion_Serv;
                servicioDB.Est_Serv = servicioVM.Est_Serv;
                ServicioServicios.ModificarServicios(servicioDB);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EliminarServicio(int id)
        {
            return ServicioServicios.EliminarServicio(id);
        }
    }
}
