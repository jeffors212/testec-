using MediatR;
using System;

namespace SistemaCompra.Domain
{
    public abstract class Event : INotification
    {
        public DateTime DataOcorrencia => DateTime.Now;
    }
}
