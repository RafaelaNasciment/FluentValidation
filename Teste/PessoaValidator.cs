using CPFCNPJ;
using FluentValidation;

namespace Teste
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(pessoa => pessoa.Nome).NotEmpty().WithMessage("O campo Nome é obrigatório.");
            RuleFor(pessoa => pessoa.Email).NotEmpty().WithMessage("O campo Email é obrigatório.")
                .EmailAddress().WithMessage("O campo Email não é um endereço de e-mail válido.");

            IMain main1 = new Main();
           
            RuleFor(pessoa => main1.IsValidCPFCNPJ(pessoa.Cpf))
                .Equal(true).WithMessage("CPF inválido.");
        }


    }
}
