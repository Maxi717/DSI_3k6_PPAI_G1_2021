//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoDSIPPAI.Clases.Persistencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsuarioPersistente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UsuarioPersistente()
        {
            this.SesionPersistente = new HashSet<SesionPersistente>();
        }
    
        public Nullable<System.DateTime> caducidad { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public Nullable<int> idEmpleado { get; set; }
        public int idUsuario { get; set; }
    
        public virtual EmpleadoPersistente EmpleadoPersistente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SesionPersistente> SesionPersistente { get; set; }
    }
}