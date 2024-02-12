using Aplicación.Servicio;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using UI.Windows.VistaModelo;

namespace UI.Windows.Controladores
{
    public class AnimalesControlador
    {
        private AnimalesServicio ServicioAnimales;
        public AnimalesControlador()
        {
            this.ServicioAnimales   = new AnimalesServicio();
        }

        public bool InsertarAnimal(AnimalesVistaModelo animalesVM)
        {
            try
            {
                Animales animalesDB = new Animales();
                animalesDB.Nombre = animalesVM.Nombre;
                animalesDB.Fecha_Nacimiento = animalesVM.Fecha_Nacimiento;
                animalesDB.ID_Especie = animalesVM.ID_Especie;
                animalesDB.ID_Raza = animalesVM.ID_Raza;
                //animalesDB.Sexo = animalesVM.Sexo;
                animalesDB.ID_Dueño_Cedula = animalesVM.ID_Dueño_Cedula;
                animalesDB.Est_Animal = animalesVM.Est_Animal;
                animalesDB.ID_Sexo = animalesVM.ID_Sexo;
                ServicioAnimales.InsertarAnimales(animalesDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Animales> ListarAnimales()
        {
            List<Animales> animales = new List<Animales>();
            try
            {
                animales = this.ServicioAnimales.ListarAnimales().ToList();
            }
            catch (Exception)
            {

            }
            return animales;
        }
        public IEnumerable<DueñoDescripcionAnimal> ListarAnimalesActivos()
        {
            return ServicioAnimales.ListarAnimalesActivos();
        }
        public bool ModificarAnimales(AnimalesVistaModelo animalesVM)
        {
            try
            {
                Animales animalesDB = new Animales();
                animalesDB.ID_Animal = animalesVM.ID_Animal;
                animalesDB.Nombre = animalesVM.Nombre;
                animalesDB.Fecha_Nacimiento = animalesVM.Fecha_Nacimiento;
                animalesDB.ID_Especie = animalesVM.ID_Especie;
                animalesDB.ID_Raza = animalesVM.ID_Raza;
                //animalesDB.Sexo = animalesVM.Sexo;
                animalesDB.ID_Dueño_Cedula = animalesVM.ID_Dueño_Cedula;
                animalesDB.Est_Animal = animalesVM.Est_Animal;
                animalesDB.ID_Sexo = animalesVM.ID_Sexo;
                ServicioAnimales.ModificarAnimales(animalesDB);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EliminarAnimal(int id)
        {
            return ServicioAnimales.EliminarAnimal(id);
        }
    }
}
