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
    
    public partial class Clases
    {
        public int id_clase { get; set; }
        public int id_curso { get; set; }
        public string nombre { get; set; }
        public string guia { get; set; }
    
        public virtual Curso Curso { get; set; }
    }
}
