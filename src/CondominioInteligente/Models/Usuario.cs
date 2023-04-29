using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioInteligente.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        public int CodUsuario { get; set; }
 
        public int CodTipoUsuario { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome")]
        public string Nome { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public ICollection<AreaComum>? AreaComums { get; set; }
    }
}
