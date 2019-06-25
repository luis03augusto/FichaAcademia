using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.dominio.Models
{
    public class Aluno
    {

        public int AlunoId { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [StringLength(100, ErrorMessage = "Use menos caracteres")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(14, 100, ErrorMessage ="Idade Inválida")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(14, 150, ErrorMessage = "Peso Inválida")]
        public decimal Peso { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(1, 150, ErrorMessage = "Frequência Inválida")]
        public int FrequenciaSemanal { get; set; }

        public ICollection<Ficha> Fichas { get; set; }
    }
}
