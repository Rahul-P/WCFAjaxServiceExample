
namespace TweetBL
{
    using System;
    using System.Runtime.Serialization;

    // This is our Data Object

    [Serializable]
    public class Tweet
    {
        public int Id { get; set; }
  
        public string PostedBy { get; set; }
       
        public string Text { get; set; }
    }
}
