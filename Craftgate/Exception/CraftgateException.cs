using exception = System.Exception;

namespace Craftgate.Exception
{
    public class CraftgateException : exception
    {
        private const string GeneralErrorCode = "0";
        private const string GeneralErrorDescription = "An error occurred.";
        private const string GeneralErrorGroup = "Unknown";
        public string ErrorCode { get; }
        public string ErrorDescription { get; }
        public string ErrorGroup { get; }

        public CraftgateException(string errorCode, string errorDescription, string errorGroup)
            : base(errorDescription)
        {
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
            ErrorGroup = errorGroup;
        }

        public CraftgateException(exception exception)
            : base(exception.Message, exception)
        {
            ErrorCode = GeneralErrorCode;
            ErrorDescription = GeneralErrorDescription;
            ErrorGroup = GeneralErrorGroup;
        }
    }
}