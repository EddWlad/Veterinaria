using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioModelo.Entidades
{
    public class DueñoDescripcionAnimal
    {
        public int id_Animal { get; set; }
        public string nombre_dueño { get; set; }
        public string nombre_mascota { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string especie { get; set; }
        public string raza { get; set; }
        public string sexo { get; set; }
        public int est_Animal { get; set; }
    }
}
