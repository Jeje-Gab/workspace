using RecuperacaoSenhaLaudos.Models.Pessoa;

namespace RecuperacaoSenhaLaudos.Services
{
    public class RecuperarSenhaLaudosServices : IRecuperarSenhaLaudosServices
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
        //public async Task BuscarSenhasLaudos(DTOs.BuscarSenhasLaudos buscarSenhasLaudosDTO)
        //// No Create recebemos DTOs que criam nova despesa
        //{
        //    await _dbContext.Expensives.AddAsync(new Pessoa()
        //    {
        //        CPF = buscarSenhasLaudosDTO.CPF,
        //        NomeCompleto = buscarSenhasLaudosDTO.NomeCompleto,
        //        NomeMaeCompleto = buscarSenhasLaudosDTO.NomeMaeCompleto,
        //        DataNascimento = buscarSenhasLaudosDTO.DataNascimento
        //    });
        //    await _dbContext.SaveChangesAsync();
        //}

        public async Task<Pessoa> BuscarSenhasLaudos(DTOs.BuscarSenhasLaudos buscarSenhasLaudosDTO)
        // Task<List> ==> Retorna uma lista de Expensive  // "FindBy" ==> Busca naqueles paramentros                                                
        {

            var Pessoas = await _dbContext.(e => e.Date >= startDate && e.Date <= endDate).AsNoTracking()
                .ToListAsync();
            // Filtrando

            return items;
        }

    }
}
