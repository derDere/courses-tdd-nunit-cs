using System;

namespace UserServiceLibrary
{
    public class ValidationException : Exception
    {
        public ValidationException(Dictionary<string, string> fields) : base(Newtonsoft.Json.JsonConvert.SerializeObject(fields)) { }
    }
}
