using System.ComponentModel.DataAnnotations;

namespace FichaAcademia.dominio.Models
{
    public class ListaExercicios
    {
        public int ListaExercicioId { get; set; }
        public int ExercicioId { get; set; }
        public Exercicio Exercicio { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(1,10, ErrorMessage = "Frequencia inválida")]
        public int Frequincia { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(1, 100, ErrorMessage = "Número inválida")]
        public int Repeticoes { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório")]
        [Range(1, 200, ErrorMessage = "Número inválida")]
        public int Carga { get; set; }

        public int FichaId { get; set; }
        public Ficha Ficha { get; set; }
    }
}