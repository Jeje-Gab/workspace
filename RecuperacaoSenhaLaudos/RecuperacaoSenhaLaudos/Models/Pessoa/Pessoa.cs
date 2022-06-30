using System.ComponentModel.DataAnnotations;

namespace RecuperacaoSenhaLaudos.Models.Pessoa
{
    public class Pessoa
    {
        [MaxLength(11)] // Tamanho maximo CPF
        public int CPF { get; set; }

        // Valor de nossa despesa
        [Required]
        public string NomeCompleto { get; set; }

        // Data de cadastro da despesa
        public DateTime DataNascimento { get; set; }

        [Required]
        public string NomeMaeCompleto { get; set; }
    }
}
