using NUnit.Framework.Internal;
using RestSharpServices;
using System.Linq.Expressions;

namespace TestGitHubApi
{
    public class TestGitHubApi
    {
        private GitHubApiClient client;
        string baseUrl = "https://dummyjson.com";       
        //int lastCreatedIssueNumber;
        //long lastCreatedCommentId;


        [SetUp]
        public void Setup()
        {
            client = new GitHubApiClient(baseUrl);
        }

        [Test, Order(1)]
        public void Test_GetAllPostsFromARepo()
        {
            //Act
            var posts = client.GetAllPosts(baseUrl);

            //Assert
            Assert.That(posts, Has.Count.GreaterThan(0), "There should be more than one posts");

            foreach (var post in posts)
            {
                Assert.That(post.Id, Is.GreaterThan(0), "Post ID should be bigger than 0");
                Assert.That(post.Title, Is.Not.Empty, "Post Title should not be empty");
                Assert.That(post.Body, Is.Not.Empty, "Post Body should not be empty");
            }
        }
    }
}
