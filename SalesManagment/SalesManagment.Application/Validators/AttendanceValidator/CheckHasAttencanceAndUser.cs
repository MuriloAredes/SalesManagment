using FluentValidation;
using SalesManagment.Context.Persistence;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract.AttendanceContracts.RegisterRequest;

namespace SalesManagment.Application.Validators.AttendanceValidator
{
    public class CheckHasAttencanceAndUser:AbstractValidator<RegisterAttendanceRequest>
    {
        private readonly ICompanyRepository _companyRepository;
        public CheckHasAttencanceAndUser(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;

            RuleFor(user => user.CompanyId)
                .Empty().WithMessage("O campo empresa não é permitido null")
                .Equal(0).WithMessage("id não pode ser igual a 0")
                .Must(HasUser).WithMessage("empresa inativo ou não registrada");
            
        }

        public  bool HasUser(int id) 
        {
            var user =  _companyRepository.Get(o => o.Id == id);
            
            if(user != null) 
                return true;
            
            return false;

        }

        public bool HasCompany(int id)
        {
            var user = _companyRepository.Get(o => o.Id == id);

            if (user != null)
                return true;

            return false;

        }
    }
}
