using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Utilities.Exceptions
{
    public class eShopException : Exception
    {
        public eShopException()
        {

        }
        public eShopException(string message) : base(message)
        {

        }
        public eShopException(string mesage, Exception inner) : base(mesage, inner)
        {

        }
    }
}
