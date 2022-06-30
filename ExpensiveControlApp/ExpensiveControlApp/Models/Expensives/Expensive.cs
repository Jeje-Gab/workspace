using System.ComponentModel.DataAnnotations;

namespace ExpensiveControlApp.Models.Expensives
{
    public class Expensive
    {
        [Key] // Mapear o ID
        public int Id { get; set; }

        [MaxLength(100)] // Tamanho maximo da Description
        public int Description { get; set; }

        // Valor de nossa despesa
        public double Value{ get; set; }

        // Data de cadastro da despesa
        public DateTime Date { get; set; }
    }
}
