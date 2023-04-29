using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioInteligente.Models
{
 
    public class AreaComum
    {
        [Key]
        public int CodArea { get; set; }
        [Required(ErrorMessage = "Obrigatório Informar o Nome")]

        public string Nome { get; set; }
    }
}
