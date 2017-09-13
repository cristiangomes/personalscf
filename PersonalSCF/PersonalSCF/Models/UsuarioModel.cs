using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalSCF.Models
{
    public class UsuarioModel
    {
        public string ID { get; set; }
        public string Cidade { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
        public string PhoneNumber { get; set; }
        public string UF { get; set; }
        public string UserFullName { get; set; }
        public DateTime DataExclusao { get; set; }
    }
}