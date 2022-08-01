using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentVoice.Business.Exceptions
{
    public class NotAvailableException : ApplicationException
    {
        public NotAvailableException(string message) : base(message)
        {

        }
    }
}
