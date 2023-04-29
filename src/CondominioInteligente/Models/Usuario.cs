using System.ComponentModel.DataAnnotations;

namespace CondominioInteligente.Models
{
    public class Usuario
    {
        [Key]
        public int Cod_Usuario { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o Nome")]

        public int Cod_Tipo_Usuario { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }
    }
}
