using Aplicación.Servicio;
using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Windows.Controladores
{
    public class SexoControlador
    {
        private SexoServicio ServicioSexo;
        public SexoControlador()
        {
            this.ServicioSexo = new SexoServicio();
        }

        public IEnumerable<Sexo> ListarSexoActivos()
        {
            return ServicioSexo.ListarRazaActivos();
        }
    }
}
