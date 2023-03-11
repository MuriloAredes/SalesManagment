using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore.Query.Internal;
using SalesManagment.Application.Validators.SellerValidator.Register;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract;
using SalesManagment.Contract.AttendanceContracts.RegisterRequest;
using SalesManagment.Domain.Entitites;
using SalesManagment.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagment.Application.AtendenceHandler.Command.Register
{
    public class RegisterAttendenceHandler : IRequestHandler<RegisterAttendanceRequest, SucessMessage>
    {
        private readonly IAttendanceRepository _repository;
        private readonly IValidator<RegisterAttendanceRequest> _validator;

        public RegisterAttendenceHandler(IAttendanceRepository repository, IValidator<RegisterAttendanceRequest> validator)
        {
            _repository= repository;
            _validator= validator;
        }
        public async Task<SucessMessage> Handle(RegisterAttendanceRequest request, CancellationToken cancellationToken)
        {
            #region Validator

            var validator = _validator.Validate(request);

            if (!validator.IsValid)
                return new SucessMessage(string.Join(",", validator.Errors.Select(x => x.ErrorMessage)));
            #endregion
            
          
            Attendance attendance = new Attendance
            {
                CompanyId = request.CompanyId,
                SellerId = request.SellerId,
                StatusAttendance = (StatusAttendance)(int)StatusAttendance.Andamento,
            };

            await _repository.Add(attendance);
            

            return new SucessMessage("Atendimento solicitado ") ;
        }
    }
}
