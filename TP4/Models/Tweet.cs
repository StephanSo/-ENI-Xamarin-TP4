using System;
using System.Diagnostics;

namespace TP4.Models
{
    public class Tweet 
    {
        private User user;
        private String dataTweet;
        private DateTime creationDate;

        public User User { get => user; set => user = value; }
        public string DataTweet { get => dataTweet; set => dataTweet = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
    }
}