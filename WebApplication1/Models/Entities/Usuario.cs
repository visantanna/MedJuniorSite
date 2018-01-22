using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models.Entities
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Insira um e-mail.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",ErrorMessage ="O formato de e-mail inserido é invalido. (Ex: teste@medjunior.com)")]
        [Remote("EmailExists", "Usuarios", HttpMethod = "POST", 
        ErrorMessage = "O e-mail criado já existe. Pode recuperar sua senha em: Recuperar senha.")]
        public string email { get; set; }

        [Required(ErrorMessage ="Insira uma senha.")]
        [DataType(DataType.Password)]
        public string senha { get; set; }

        public string faculdade { get; set; }

        [Required(ErrorMessage ="Insira seu nome completo.")]
        public String nomeCompleto { get; set; }

        public int anoDeIngresso { get; set; }
        
    }
    public class UsuarioDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}