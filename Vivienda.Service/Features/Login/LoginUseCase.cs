using Vivienda.Domain.Common;
using Vivienda.Service.Contract;

using MediatR;

using System.Threading;
using System.Threading.Tasks;

namespace Vivienda.Service.Features.Login
{
    public class LoginRequest : IRequest<Response<string>>
    { 
    }
    public class LoginUseCase : IRequestHandler<LoginRequest, Response<string>>
    {
        public LoginUseCase(IAuthenticator authenticator)
        { }
        public Task<Response<string>> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }

}
