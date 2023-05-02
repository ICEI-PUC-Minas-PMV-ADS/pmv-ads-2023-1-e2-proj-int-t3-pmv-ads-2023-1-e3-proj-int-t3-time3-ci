using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioInteligente.Models
{
    public class Moradia
    {
        [Key]
        public int CodMoradia { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a identificação da Moradia")]
        public string IdentificadorMoradia { get; set; } = string.Empty;

        [Display(Name = "Proprietário")]
        public int CodUsuario { get; set; }
        
        // adicionado interligação da classe moraria com o proprietario
        [ForeignKey("CodUsuario")]
        public Usuario? Proprietario { get; set; }
    }
}
