using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class IntegritException : ApplicationException

    {
        public IntegritException(string message) : base(message)
        {

        }
    }
}
