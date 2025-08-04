using MediatR;
using Messaging.Application.Common.DataTransferModels;
using Messaging.Application.Common.JWT.Interfaces;
using Messaging.Domain.Entities.UserPerson;
using Messaging.Domain.UnitOfWorkPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Application.CQRS.PersonUser.Handlers
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public RegisterUserHandler(IUnitOfWork unitOfWork, IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            Messaging.Domain.Entities.UserPerson.Person person = new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName
            };

            User user = new()
            {
                Username = request.Username,
                Email = request.Email,
                Phone = request.Phone,
                HashedPassword = PasswordHasher.HashPassword(request.Password),
                Person = person
            };

            await _unitOfWork.UserRepository.AddAsync(user, cancellationToken);

            await _unitOfWork.CompleteTaskAsync(cancellationToken);

            return _jwtTokenGenerator.GenerateToken(user);
        }
    }
}
