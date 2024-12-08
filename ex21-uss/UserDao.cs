using System;

namespace UserServiceLibrary
{
    public class UserDao
    {
        public virtual Task<object> Get(string identifier)
        {
            throw new NotImplementedException("Implement me");
        }

        // public virtual Task Save(string identifier, object obj)
        // {
        //     throw new NotImplementedException("Implement me");
        // }
    }

    public class DaoException : Exception
    {
        public DaoException(string message, Exception cause = null) : base(message, cause) { }
    }

    // public class UserDaoDictionaryImpl : UserDao
    // {
    //     private readonly Dictionary<string, object> _repo;

    //     public UserDaoDictionaryImpl(Dictionary<string, object> repo = null)
    //     {
    //         _repo = repo ?? new Dictionary<string, object>();
    //     }

    //     public override Task<object> Get(string identifier)
    //     {
    //         _repo.TryGetValue(identifier, out var result);
    //         return Task.FromResult(result);
    //     }

    //     public override Task Save(string identifier, object obj)
    //     {
    //         _repo[identifier] = obj;
    //         return Task.CompletedTask;
    //     }
    // }
}
