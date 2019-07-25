using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FichaAcademia.dominio.Models
{
    public class Exercicio
    {
        public int ExercicioId { get; set; }
        [Required(ErrorMessage ="Campo {0} obrigatório")]
        [StringLength(50, ErrorMessage ="Use menos caracteres")]
        public string Nome { get; set; }

        public int CateforiaExercicoId { get; set; }
        public CategoriaExercicio CategoriaExercicio { get; set; }

        public ICollection<ListaExercicios> ListaExercicios { get; set; }
    }
}
