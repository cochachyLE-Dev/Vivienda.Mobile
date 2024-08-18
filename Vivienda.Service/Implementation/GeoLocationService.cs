using Vivienda.Service.Contract;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Vivienda.Service.Implementation
{
    public class GeoLocationService : IGeoLocationService
    {
        public Task<Tuple<double, double>> GetCurrentLocation(CancellationTokenSource cts)
        {
            throw new NotImplementedException();
        }
    }
}
