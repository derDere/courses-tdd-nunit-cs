using System;

namespace UserServiceLibrary
{
    public class PersonOdataProvider
    {
        public virtual Task<object> Get(string identifier)
        {
            throw new NotImplementedException("Implement me");
        }
    }

    public class ProviderException : Exception
    {
        public ProviderException(string message, Exception cause = null) : base(message, cause) { }
    }
}
