using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSueldos
{
    public class Empleado // Declaracion de clase, getters y setters
    {
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set;}
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public string VALOR_HORA { get; set; }
        public string VALOR_EXTRA { get; set; }
        public string SUELDO_LIQ { get; set; }
        public string SUELDO_BRUT { get; set; }
    }
}
