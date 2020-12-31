using exception = System.Exception;

namespace Craftgate.Exception
{
    public class CraftgateException : exception
    {
        private const string GeneralErrorCode = "0";
        private const string GeneralErrorDescription = "An error occurred.";
        private const string GeneralErrorGroup = "Unknown";
        private string _errorCode;
        private string _errorDescription;
        private string _errorGroup;

        public CraftgateException(string errorCode, string errorDescription, string errorGroup)
            : base(errorDescription)
        {
            _errorCode = errorCode;
            _errorDescription = errorDescription;
            _errorGroup = errorGroup;
        }

        public CraftgateException(exception exception)
            : base(exception.Message, exception)
        {
            _errorCode = GeneralErrorCode;
            _errorDescription = GeneralErrorDescription;
            _errorGroup = GeneralErrorGroup;
        }
    }
}