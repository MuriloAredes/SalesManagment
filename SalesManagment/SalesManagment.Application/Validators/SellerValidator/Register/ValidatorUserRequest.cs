using FluentValidation;
using SalesManagment.Context.Persistence.interfaces;

namespace SalesManagment.Application.Validators.SellerValidator.Register
{
    public class CheckEmailRequest
    {
        public Domain.Entitites.Seller User { get; set; } = new Domain.Entitites.Seller();
    }
    public class ValidatorUserRequest: AbstractValidator<CheckEmailRequest>
    {
        
        public ValidatorUserRequest()
        {
            RuleFor(x => x.User)
                .NotNull().WithMessage("existing email");
        }

       
    }
}
