using System;

namespace SolveCaptcha.Exceptions
{
    public class ValidationException : Exception {

        public ValidationException(string message) : base (message) {
            
        }

    }
}