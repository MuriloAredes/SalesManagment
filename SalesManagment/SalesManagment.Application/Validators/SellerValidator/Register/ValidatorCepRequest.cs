using FluentValidation;
using SalesManagment.Domain.Dto;

namespace SalesManagment.Application.Validators.SellerValidator.Register
{
    public class CheckCepRequest 
    {
        public SearchResultCepDto obj { get; set; } = new SearchResultCepDto();
    }
    public class ValidatorCepRequest : AbstractValidator<CheckCepRequest>
    {

        public ValidatorCepRequest()
        {
            RuleFor(x => x.obj)
                .Empty().WithMessage("cep invalido")
                .Null().WithMessage("cep invalido");
        }
    }
}
