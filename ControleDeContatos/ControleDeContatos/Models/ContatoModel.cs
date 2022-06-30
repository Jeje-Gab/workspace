namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        // Criando atributos 
        public int Id { get; set; }
        // Id -> Identificador de cada registro

        // Receberá o nome do Usuario
        public string? Nome { get; set; }
        // "string?" -> serve para não deixar que a mesma seja nula e deixar ao menos vazia para que não de erro

        public string? Email { get; set; }

        public string? Celular { get; set; }

        // O banco de dados terá basicamente estas 4 colunas a cima

    }
}
