using System.ComponentModel.DataAnnotations;

namespace ExpensiveControlApp.DTOs
{
    public class CreateExpensiveDTO
    // Propiedades necessarias para criar as despesas: 
    // Description
    // Value
    // Data
    {

        // Validações destes campos se encontram entre "[]"

        [Required(ErrorMessage = "Descrição é obrigatoria")]
        public int Description { get; set; }

        [Required(ErrorMessage = "Valor é obrigatoria")]
        // Por conta de querer acima de 0 o valor podemos utilizar o "Range"
        [Range(0.01, 9999999999999, ErrorMessage = "Valor deve ser maior que 0.")]
        public double Value { get; set; }

        [Required(ErrorMessage = "Data é obrigatorio")]
        public DateTime Date { get; set; }
    }
}
