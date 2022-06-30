using ExpensiveControlApp.Models.Expensives;

namespace ExpensiveControlApp.DTOs
{
    public class ListExpensiveDTO
    {
        // Logo apos o construtor/ apos sua iniciialização
        public ListExpensiveDTO()
        // Valores pdrões para inicialização
        {
            // Valor padrão de inicialização do StartDate
            StartDate = DateTime.UtcNow.AddDays(-7);
            // O mesmo starta como 7 dias atras por padrão

            EndDate = DateTime.UtcNow.AddDays(3);
            // || || || finaliza com 3 dias a frente

            Items = new List<Expensive>(); 
            // Previne que nossa lista fique nula
        }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public List<Expensive> Items { get; set; }
    }
}
