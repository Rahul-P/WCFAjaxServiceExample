

namespace Tweet.WCFService.AJAX
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.ServiceModel.Web;
    using TweetBL;

    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = 
        AspNetCompatibilityRequirementsMode.Allowed)]
    public class TweetService
    {
        private TweetBL.ManageTweet _businessLayerTweetService;

        public TweetService()
        {
            _businessLayerTweetService = new TweetBL.ManageTweet();
        }

        [OperationContract]
        [WebGet] //(ResponseFormat=WebMessageFormat.Xml)
        public IList<Tweet> GetTweets()
        {
            return _businessLayerTweetService.GetTweets();
        }

        [OperationContract]
        [WebGet]
        public Tweet GetTweetByID(int tweetId)
        {
            return _businessLayerTweetService.GetTweetById(tweetId);
        }

        [OperationContract]
        [WebInvoke]
        public void CreateTweet(Tweet newTweet)
        {
            _businessLayerTweetService.CreateTweet(newTweet);
        }

        [OperationContract]
        [WebInvoke]
        public void UpdateTweet(Tweet updateTweet)
        {
            _businessLayerTweetService.UpdateTweet(updateTweet);
        }

        [OperationContract]
        [WebInvoke]
        public void DeleteTweet(int deleteTweetId)
        {
            _businessLayerTweetService.DeleteTweet(deleteTweetId);
        }
    }
}
