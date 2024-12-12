using System;

namespace UserServiceLibrary
{
    public interface Provider<T>
    {
        T Get(string identifier);
    }

    public class ProviderException : Exception
    {
        public ProviderException(string message, Exception cause = null) : base(message, cause) { }
    }
}
