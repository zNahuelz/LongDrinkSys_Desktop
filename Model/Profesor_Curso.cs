//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LongDrinkSys_Local.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profesor_Curso
    {
        public int id_profesor { get; set; }
        public int id_curso { get; set; }
        public System.DateTime fecha_inicio { get; set; }
        public System.DateTime fecha_final { get; set; }
    
        public virtual Curso Curso { get; set; }
        public virtual Profesor Profesor { get; set; }
    }
}
