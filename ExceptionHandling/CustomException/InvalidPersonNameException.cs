using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    class InvalidPersonNameException : Exception
    {
        public string Message;
        public InvalidPersonNameException(string message)
        {
            this.Message = message;
        }
    }
}
