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
    
    public partial class SedePersistente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SedePersistente()
        {
            this.EmpleadoPersistente = new HashSet<EmpleadoPersistente>();
            this.EntradaPersistente = new HashSet<EntradaPersistente>();
            this.ReservaVisitaPersistente = new HashSet<ReservaVisitaPersistente>();
            this.ExposicionPersistente = new HashSet<ExposicionPersistente>();
            this.TarifaPersistente = new HashSet<TarifaPersistente>();
        }
    
        public int cantMaximaVisitantes { get; set; }
        public int cantMaxPorGuia { get; set; }
        public string nombre { get; set; }
        public int idSede { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpleadoPersistente> EmpleadoPersistente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntradaPersistente> EntradaPersistente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservaVisitaPersistente> ReservaVisitaPersistente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExposicionPersistente> ExposicionPersistente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TarifaPersistente> TarifaPersistente { get; set; }
    }
}