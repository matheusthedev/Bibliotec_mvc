using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Livro
    {

        [Key]
        public int LivroID;
        public string ?Nome;
        public string ?Escritor;
        public string ?Editora;
        public string ?Descricao;
        public string ?Idioma;
        public string ?Imagem;
        public string ?Reservado;
        public bool Ativo;
    }
}