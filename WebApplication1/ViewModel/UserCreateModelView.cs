using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Enums;

namespace WebApplication1.ViewModel
{
    public class UserCreateModelView
    {

        public int ID { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Insira um e-mail.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "O formato de e-mail inserido é invalido. (Ex: teste@medjunior.com)")]
        [Remote("EmailExists", "Usuarios", HttpMethod = "POST",
        ErrorMessage = "O e-mail criado já existe. Pode recuperar sua senha em: Recuperar senha.")]
        public string email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Insira uma senha.")]
        [DataType(DataType.Password)]
        public string senha { get; set; }

        [Display(Name = "Confirme a senha")]
        [Required(ErrorMessage = "Insira uma senha.")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.CompareAttribute("senha", ErrorMessage = "Senhas inseridas não são iguais.")]
        public string confirmSenha { get; set; }

        [Display(Name = "Faculdade")]
        public Faculdade faculdade { get; set; }

        [Required(ErrorMessage = "Insira seu nome completo.")]
        [Display(Name = "Nome Completo")]
        public String nomeCompleto { get; set; }

        [Display(Name = "Ano de Ingresso")]
        public String anoDeIngresso { get; set; }


    }
}