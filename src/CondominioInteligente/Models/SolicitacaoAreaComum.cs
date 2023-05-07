using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioInteligente.Models
{
    public class SolicitacaoAreaComum
    {
        [Key]
        public int CodSolictacao { get; set; }

        [Display(Name = "Usuário Solicitação")]
        [Required(ErrorMessage = "Obrigatório informar o Area ")]
        public int CodUsuario { get; set; }

        [ForeignKey("CodUsuario")]
        public Usuario? UsuarioSolictante { get; set; }

        [Display(Name = "Area Comum")]
        [Required(ErrorMessage = "Obrigatório informar o Area ")]
        public int CodArea { get; set; }

        [ForeignKey("CodArea")]
        public AreaComum? Area { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        [Required]
        public DateTime DataFim { get; set; }

        public bool? aprovado { get; set; } 

    }
}
