//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalSCF.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_lancamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_lancamento()
        {
            this.rl_usuario_lancamento = new HashSet<rl_usuario_lancamento>();
        }
    
        public string ID { get; set; }
        public string ID_Banco { get; set; }
        public string Nome { get; set; }
        public string NomeEvento { get; set; }
        public decimal Valor { get; set; }
        public Nullable<System.DateTime> DataEvento { get; set; }
        public Nullable<System.DateTime> DataExclusao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rl_usuario_lancamento> rl_usuario_lancamento { get; set; }
        public virtual tb_conta tb_conta { get; set; }
    }
}
