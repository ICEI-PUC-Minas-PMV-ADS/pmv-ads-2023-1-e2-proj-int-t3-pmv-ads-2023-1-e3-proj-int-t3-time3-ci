using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CondominioInteligente.Models
{
    public class Encomenda
    {
        [Key]
        public int CodEncomenda { get; set; }

        
        public Byte[] FotoEncomenda { get; set; }

        [Display(Name = "Porteiro")]
        public int CodUsuario { get; set; }

        // adicionado interligação da classe encomenda com a classe usuario
        [ForeignKey("CodUsuario")]
        public Usuario? Porteiro { get; set; }
    }
}
