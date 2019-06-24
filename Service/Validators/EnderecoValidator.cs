using FluentValidation;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Validators
{
    class EnderecoValidator : AbstractValidator<Endereco>
    {
        public EnderecoValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Não existe o objeto procurado.");
                });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("É necessário informar o CPF.")
                .NotNull().WithMessage("É necessário informar o CPF.");

            RuleFor(c => c.idade)
                .NotEmpty().WithMessage("É necessário informar a idade.")
                .NotNull().WithMessage("É necessário informar a idade.");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("É necessário informar o Nome.")
                .NotNull().WithMessage("É necessário informar o Nome.");
        }
    }
}
