using System;
using System.Threading;
using System.Threading.Tasks;

namespace Vivienda.Service.Contract
{
    public interface IGeoLocationService
    {
        Task<Tuple<double, double>> GetCurrentLocation(CancellationTokenSource cts);
    }
}
