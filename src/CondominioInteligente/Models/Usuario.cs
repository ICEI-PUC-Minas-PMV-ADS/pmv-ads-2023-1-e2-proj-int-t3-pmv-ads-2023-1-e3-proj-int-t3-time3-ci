﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioInteligente.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        public int CodUsuario { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o Nome")]

        public int CodTipoUsuario { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public ICollection<AreaComum> AreaComums { get; set; }
    }
}
