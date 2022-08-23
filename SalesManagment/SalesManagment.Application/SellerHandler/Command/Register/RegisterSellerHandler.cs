using FluentValidation;
using MediatR;
using SalesManagment.Application.Interactor.interfaces;
using SalesManagment.Application.Validators.SellerValidator.Register;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract;
using SalesManagment.Contract.SellerContracts.RegisterRequest;

namespace SalesManagment.Application.SellerHandler.Command.Register
{
    public class RegisterSellerHandler : IRequestHandler<RegisterSellerRequest, SucessMessage>
    {
        private readonly ISellerRepository _sellerRespository;
        private readonly ISearchByZipCodeInteractor _searchByZipCodeInteractor;
        private readonly IValidator<CheckCepRequest> _validatorCep;
        private readonly IValidator<CheckEmailRequest> _validatorEmail;

        public RegisterSellerHandler(ISellerRepository sellerResponse, 
                                     ISearchByZipCodeInteractor searchByZipCodeInteractor,
                                     IValidator<CheckCepRequest> validatorCep,
                                     IValidator<CheckEmailRequest> validatorEmail)
        {
            _sellerRespository = sellerResponse;
            _searchByZipCodeInteractor = searchByZipCodeInteractor;
            _validatorCep = validatorCep;
            _validatorEmail = validatorEmail;
        }
        public async  Task<SucessMessage> Handle(RegisterSellerRequest request, CancellationToken cancellationToken)
        {
          
            #region ValidatorCep
            var adress = await _searchByZipCodeInteractor.SearchByZipCode(request.Cep);

            var validator = _validatorCep.Validate(new CheckCepRequest {obj = adress });

            if (!validator.IsValid)
                return new SucessMessage(string.Join(",", validator.Errors.Select(x => x.ErrorMessage)));
            #endregion

            #region ValidatorHasUser
            var user = await _sellerRespository.Get(e => e.Email.Equals(request.Email));

            var validatorEmail = _validatorEmail.Validate(new CheckEmailRequest { User = user});

            if (!validatorEmail.IsValid)
               return new SucessMessage(string.Join(",", validator.Errors.Select(x => x.ErrorMessage)));
#endregion

            var seller = new Domain.Entitites.Seller
            {
                Name = request.FirstName.Trim(),
                LastName = request.LastName.Trim(),
                Email = request.Email,
                Cep = request.Cep,
                Adress = adress.Rua,
                Number = request.Number,
                Complement = request.Complement
            };
                await _sellerRespository.Add(seller);

            return new SucessMessage("Register Success");
        }
    }
}
