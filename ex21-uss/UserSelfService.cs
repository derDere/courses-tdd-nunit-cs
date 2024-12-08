using System;
using System.Collections.Generic;

namespace UserServiceLibrary
{
    public class UserSelfService { }

    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserSelfServiceException : Exception { }

    public class UserException : UserSelfServiceException { }

    public class ServerException : UserSelfServiceException { }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Emails { get; set; } = new List<string>();
    }

    public class UserSession { }
}
