using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CondominioInteligente.Models
{
    public class Reuniao
    {
        [Key]

        public int CodReuniao { get; set; }


        [Required(ErrorMessage = "Obrigatório Informar data e hora da reunião")]
        public DateTime Data { get; set; }

        public string NomeReuniao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório Informar a pauta da reunião")]
        public string  Pauta { get; set; } = string.Empty;

        public string Ata { get; set; } = string.Empty;

        public int CodUsuario { get; set; }

        // adicionado interligação da classe reuniao com o usuario master
        [ForeignKey("CodUsuario")]
        public Usuario? UsuarioMaster { get; set; }

        public ICollection<Documento>? Documentos { get; set; }




    }
}
