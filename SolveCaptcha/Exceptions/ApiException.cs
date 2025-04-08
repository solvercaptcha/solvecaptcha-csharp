using System;

namespace SolveCaptcha.Exceptions
{
    public class ApiException : Exception {

        public ApiException(string message) : base (message) {
            
        }

    }
}
