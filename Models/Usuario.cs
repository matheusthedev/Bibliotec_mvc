using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {

        [Key]
        public int UsuarioID;
        public string? Nome;
        public DateOnly DtNascimento;
        public string? Email;
        public string? Senha;
        public string? Contato;
        public bool Admin;
        public bool Status;

        [ForeignKey("Curso")]
        public int CursoID { get; set; }

        public Curso Curso { get; set; }
    }
}