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
    public class EspecieControlador
    {
        private EspecieServicio ServicioEspecie;
        public EspecieControlador()
        {
            this.ServicioEspecie = new EspecieServicio();   
        }

        public bool InsertarEspecie(EspecieVistaModelo EspecieVM)
        {
            try
            {
                Especie EspecieDB = new Especie();
                EspecieDB.Nom_Especie = EspecieVM.Nom_Especie;
                EspecieDB.Est_Especie = EspecieVM.Est_Especie;
                this.ServicioEspecie.InsertarEspecie(EspecieDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Especie> ListarEspecieActivos()
        {
            return ServicioEspecie.ListarEspecieActivos();
        }

        public bool ModificarEspecie(EspecieVistaModelo EspecieVM)
        {
            try
            {
                Especie EspecieDB = new Especie();
                EspecieDB.ID_Especie = EspecieVM.ID_Especie;
                EspecieDB.Nom_Especie = EspecieVM.Nom_Especie;
                EspecieDB.Est_Especie = EspecieVM.Est_Especie;
                this.ServicioEspecie.ModificarEspecie(EspecieDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EliminarEspecie(int id)
        {
            return ServicioEspecie.EliminarEspecie(id);
        }
    }
}
