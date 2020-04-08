﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeControleDeTCCs.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [DisplayName("Nome")]
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Este campo e obrigatório!")]
        public string Nome { get; set; }

        [DisplayName("Matrícula")]
        [Column(TypeName = "nvarchar(25)")]
        [Required(ErrorMessage = "Este campo e obrigatório!")]
        public string Matricula { get; set; }

        [DisplayName("CPF")]
        [Column(TypeName = "nvarchar(11)")]
        public string cpf { get; set; }

        [DisplayName("Telefone")]
        [Column(TypeName = "nvarchar(11)")]
        public string  telefone { get; set; }

        [DisplayName("E-mail")]
        [Column(TypeName = "nvarchar(25)")]
        public string  email { get; set; }

        public ICollection<Tcc> Tccs { get; set; }

        public TipoUsuario TipoUsuario { get; set; }
    }
}
