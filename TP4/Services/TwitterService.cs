using System;
using System.Collections.Generic;
using System.Linq;
using TP4.Models;
using Xamarin.Forms;

namespace TP4.Services
{
    public class TwitterService : ITwitterService
    {
       public List<Tweet> Tweets
        {
            get
            {
                User user = new User() { Login = "sonnois", Pass = "sonnois" };
                return new List<Tweet>()
                {
                    new Tweet(){User = user, DataTweet="Test",CreationDate =DateTime.Now}
                };
            }
        }
       public Boolean Authenticate(User user)
        {
            return Tweets.Select(x => x.User).Any(x => x.Login == user.Login && x.Pass == user.Pass);
        }
    }
}