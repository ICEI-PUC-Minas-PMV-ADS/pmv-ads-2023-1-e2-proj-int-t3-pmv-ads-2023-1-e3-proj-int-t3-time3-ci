using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CondominioInteligente.Models;

namespace CondominioInteligente.Data
{
    public class CondominioInteligenteContext : DbContext
    {
        public CondominioInteligenteContext (DbContextOptions<CondominioInteligenteContext> options)
            : base(options)
        {
        }

        public DbSet<CondominioInteligente.Models.Usuario> Usuario { get; set; } = default!;

        public DbSet<CondominioInteligente.Models.AreaComum>? AreaComum { get; set; }

        public DbSet<CondominioInteligente.Models.Moradia>? Moradia { get; set; }

        public DbSet<CondominioInteligente.Models.Reuniao>? Reuniao { get; set; }

        public DbSet<CondominioInteligente.Models.Documento>? Documento { get; set; }

        public DbSet<CondominioInteligente.Models.SolicitacaoAreaComum>? SolicitacaoAreaComum { get; set; }
    }
}
