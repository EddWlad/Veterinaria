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
    public class RazaControlador
    {
        private RazaServicio ServicioRaza;
        public RazaControlador()
        {
            this.ServicioRaza = new RazaServicio();
        }


        public bool InsertarRaza(RazaVistaModelo RazaVM)
        {
            try
            {
                Raza RazaDB = new Raza();
                RazaDB.Nombre_Raza = RazaVM.Nombre_Raza;
                RazaDB.Est_Raza = RazaVM.Est_Raza;
                ServicioRaza.InsertarRaza(RazaDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Raza> ListarRazaActivos()
        {
            return ServicioRaza.ListarRazaActivos();
        }
        public bool ModificarRaza(RazaVistaModelo razaVM)
        {
            try
            {
                Raza RazaDB = new Raza();
                RazaDB.ID_Raza = razaVM.ID_Raza;
                RazaDB.Nombre_Raza = razaVM.Nombre_Raza;
                RazaDB.Est_Raza = razaVM.Est_Raza;
                ServicioRaza.ModificarRaza(RazaDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EliminarRaza(int id)
        {
            return ServicioRaza.EliminarRaza(id);
        }
    }
}
