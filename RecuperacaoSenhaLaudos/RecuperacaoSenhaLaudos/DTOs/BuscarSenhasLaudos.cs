using RecuperacaoSenhaLaudos.Models.Pessoa;
using System.ComponentModel.DataAnnotations;

namespace RecuperacaoSenhaLaudos.DTOs
{
    public class BuscarSenhasLaudos
    {
        public BuscarSenhasLaudos()
        {
            Pessoa = new Pessoa();
        }


        // Validações destes campos se encontram entre "[]"
        [Required(ErrorMessage = "CPF é obrigatorio.")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "Nome é obrigatorio.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Nome da mãe é obrigatório.")]
        public string NomeMaeCompleto { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatorio")]
        public DateTime DataNascimento { get; set; }

        public Pessoa Pessoa { get; set; }

    }
}
