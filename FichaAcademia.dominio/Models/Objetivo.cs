﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.dominio.Models
{
    public class Objetivo
    {
        public int ObjetivoId { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [StringLength(500, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
    }
}
