using System;
using System.Collections.Generic;

namespace Vivienda.Domain.Common
{
    public interface IResponse<T>
    {
        Status Status { get; }
        IEnumerable<string> Errors { get; }
        T PayLoad { get; }
    }
    public class Response<T> : IResponse<T>
    {
        public T PayLoad { get; }
        public Status Status { get; }
        public IEnumerable<string> Errors { get; private set; }
        public Exception Exception { get; private set; }

        public bool Succeeded => Status == Status.Success;

        public Response(T payload) 
        {
            PayLoad = payload!;
        }
        private Response(Status status)
        {
            Status = status!;
        }
    }
    public enum Status
    { 
        Success,
        Failed,
        Unauthorized
    }
}
