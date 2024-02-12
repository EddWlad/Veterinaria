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
    public class DueñoControlador
    {
        private DueñoServicio ServicioDueño;
        public DueñoControlador()
        {
            this.ServicioDueño = new DueñoServicio();
        }


        public bool InsertarDueño(DueñoVistaModelo DueñoVM)
        {
            try
            {
                Dueño DueñoDB = new Dueño();
                DueñoDB.ID_Dueño_Cedula = DueñoVM.ID_Dueño_Cedula;
                DueñoDB.Nombre_Dueño = DueñoVM.Nombre_Dueño;
                DueñoDB.Apellido_Dueño = DueñoVM.Apellido_Dueño;
                DueñoDB.Dirección_Dueño = DueñoVM.Dirección_Dueño;
                DueñoDB.Telefono_Dueño = DueñoVM.Telefono_Dueño;
                DueñoDB.Email_Dueño = DueñoVM.Email_Dueño;
                DueñoDB.Est_Dueño = DueñoVM.Est_Dueño;
                ServicioDueño.InsertarDueño(DueñoDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Dueño> ListarDueñoActivos()
        {
            return ServicioDueño.ListarDueñoActivos();
        }

        public bool ModificarDueño(DueñoVistaModelo DueñoVM)
        {
            try
            {
                Dueño DueñoDB = new Dueño();
                DueñoDB.ID_Dueño_Cedula = DueñoVM.ID_Dueño_Cedula;
                DueñoDB.Nombre_Dueño = DueñoVM.Nombre_Dueño;
                DueñoDB.Apellido_Dueño = DueñoVM.Apellido_Dueño;
                DueñoDB.Dirección_Dueño = DueñoVM.Dirección_Dueño;
                DueñoDB.Telefono_Dueño = DueñoVM.Telefono_Dueño;
                DueñoDB.Email_Dueño = DueñoVM.Email_Dueño;
                DueñoDB.Est_Dueño = DueñoVM.Est_Dueño;
                ServicioDueño.ModificarDueño(DueñoDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EliminarCliente(string id)
        {
            return ServicioDueño.EliminarCliente(id);
        }
    }
}
