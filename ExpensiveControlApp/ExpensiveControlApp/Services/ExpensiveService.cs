using ExpensiveControlApp.Infra.DataBase;
using ExpensiveControlApp.Models.Expensives;
using Microsoft.EntityFrameworkCore;

namespace ExpensiveControlApp.Services
{
    public class ExpensiveService : IExpensiveService
    {
        // "ExpensiveControlContext" -> Contexto

        // Injeção de dependencia do contexto a cima
        private readonly ExpensiveControlContext _dbContext;
        // O "_" serve para diferenciar de variavel privada

        // Construtor
        public ExpensiveService(ExpensiveControlContext context)
        {
            _dbContext = context;
        }

        // função Cria nova despesa
        public async Task Create(DTOs.CreateExpensiveDTO createExpensiveDTO)
        // No Create recebemos DTOs que criam nova despesa
        {
            await _dbContext.Expensives.AddAsync(new Expensive()
            {
                Description = createExpensiveDTO.Description,
                Date = createExpensiveDTO.Date,
                Value = createExpensiveDTO.Value
            });
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Expensive>> FindBy(DateTime startDate, DateTime endDate)
        // Task<List> ==> Retorna uma lista de Expensive  // "FindBy" ==> Busca naqueles paramentros                                                
        {
            if (startDate > endDate)
            {
                // Caso a data de inicio for menor que a data final está errado pois a mesma não pode ser menor
                throw new Exception("Data Final deve ser maior que data incial.");
            }

            var items = await _dbContext.Expensives.Where(e => e.Date >= startDate && e.Date <= endDate).AsNoTracking()
                .ToListAsync();
            // Filtrando

            return items;
        }
    }
}
