using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroCategoria
    {
        [Key]
        public int LivroCategoriaID;
        [ForeignKey("Livro")]
        public int LivroID;
        public Livro Livro { get; set; }

        [ForeignKey("Categoria")]
        public int CategoriaID;
        public Categoria Categoria { get; set; }
    }
}