using System;

namespace TalisSoft.Common.Application.Exceptions
{
    public class NotFoundException: ApplicationException
    {
        public NotFoundException(string name, object key): base($"{name} ({key}) not found")
        {
        }
    }
}