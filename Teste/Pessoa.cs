using FluentValidation.Results;

namespace Teste
{
    public class Pessoa : PessoaValidator
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public (bool, List<ValidationFailure> errorMessage) Validacao()
        {
            var validate = Validate(this);
            return (validate.IsValid, validate.Errors);
        }
    }
}
