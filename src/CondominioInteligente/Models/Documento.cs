using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioInteligente.Models
{
    public class Documento
    {
        [Key]
        public int CodDocumento { get; set; }

        [Display(Name = "Documento")]
        public Byte[] Arquivo { get; set; }

        public int CodReuniao { get; set; }

        // adicionado interligação da classe documento com a classe reunião
        [ForeignKey("CodReuniao")]
        public Reuniao? Reuniao { get; set; }


    }
}
