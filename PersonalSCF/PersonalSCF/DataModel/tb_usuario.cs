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
    
    public partial class tb_usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_usuario()
        {
            this.rl_usuario_lancamento = new HashSet<rl_usuario_lancamento>();
        }
    
        public string ID { get; set; }
        public string Cidade { get; set; }
        public string CPF { get; set; }
        public System.DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string UF { get; set; }
        public string UserFullName { get; set; }
        public Nullable<System.DateTime> DataExclusao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rl_usuario_lancamento> rl_usuario_lancamento { get; set; }
    }
}
