using System.Threading.Tasks;

namespace Vivienda.Service.Contract
{
    public interface IOutputPort<in T>
    {
        Task Handler(T response);
    }
}
