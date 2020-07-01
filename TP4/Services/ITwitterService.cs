using System;
using System.Collections.Generic;
using TP4.Models;
namespace TP4.Services
{
    public interface ITwitterService
    {
        Boolean Authenticate(User user);
        List<Tweet> Tweets { get; }
    }
}
