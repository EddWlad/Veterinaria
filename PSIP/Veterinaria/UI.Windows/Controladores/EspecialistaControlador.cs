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
    public class EspecialistaControlador
    {
        private EspecialistaServicio ServicioEspecialista;
        public EspecialistaControlador()
        {
            this.ServicioEspecialista = new EspecialistaServicio();
        }

        public bool InsertarEspecialista(EspecialistaVistaModelo EspecialistaVM)
        {
            try
            {
                Especialista EspecialistaDB = new Especialista();
                EspecialistaDB.ID_Especialista_Cedula = EspecialistaVM.ID_Especialista_Cedula;
                EspecialistaDB.Nombre_Espe = EspecialistaVM.Nombre_Espe;
                EspecialistaDB.Apellido_Espe = EspecialistaVM.Apellido_Espe;
                EspecialistaDB.Telefono_Espe = EspecialistaVM.Telefono_Espe;
                EspecialistaDB.Email_Espe = EspecialistaVM.Email_Espe;
                EspecialistaDB.Especialización_Espe = EspecialistaVM.Especialización_Espe;
                EspecialistaDB.ID_Servicio = EspecialistaVM.ID_Servicio;
                EspecialistaDB.Est_Espe = EspecialistaVM.Est_Espe;
                this.ServicioEspecialista.InsertarEspecialista(EspecialistaDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Especialista> ListarEspecialista()
        {
            List<Especialista> especialista = new List<Especialista>();
            try
            {
                especialista = this.ServicioEspecialista.ListarEspecialista().ToList();
            }
            catch (Exception)
            {

            }
            return especialista;
        }
        public IEnumerable<Especialista> ListarEspecialistaActivos()
        {
            return ServicioEspecialista.ListarEspecialistaActivos();
        }
        public bool ModificarEspecialista(EspecialistaVistaModelo EspecialistaVM)
        {
            try
            {
                Especialista EspecialistaDB = new Especialista();
                EspecialistaDB.ID_Especialista_Cedula = EspecialistaVM.ID_Especialista_Cedula;
                EspecialistaDB.Nombre_Espe = EspecialistaVM.Nombre_Espe;
                EspecialistaDB.Apellido_Espe = EspecialistaVM.Apellido_Espe;
                EspecialistaDB.Telefono_Espe = EspecialistaVM.Telefono_Espe;
                EspecialistaDB.Email_Espe = EspecialistaVM.Email_Espe;
                EspecialistaDB.Especialización_Espe = EspecialistaVM.Especialización_Espe;
                EspecialistaDB.ID_Servicio = EspecialistaVM.ID_Servicio;
                EspecialistaDB.Est_Espe = EspecialistaVM.Est_Espe;
                this.ServicioEspecialista.ModificarEspecialista(EspecialistaDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
