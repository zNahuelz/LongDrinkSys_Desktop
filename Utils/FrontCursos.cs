using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongDrinkSys_Local.Utils
{
    public class FrontCursos
    {
        public int id_curso { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double costo { get; set; }
        public byte duracion { get; set; }
        public bool estado { get; set; }
        public string frontEstado { get; set; }
    }
}
