using Vivienda.Domain.Common;

using System.Threading.Tasks;

namespace Vivienda.Service.Contract
{
    public interface IAuthenticator
    {
        Task<Response<string>> AuthenticateAsync();
    }
}
