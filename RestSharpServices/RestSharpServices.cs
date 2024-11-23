using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpServices.Models;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace RestSharpServices
{
    public class GitHubApiClient
    {

        private RestClient client;
        public GitHubApiClient(string baseUrl)
        {           
            this.client = new RestClient(baseUrl);
        }

        public List<Post>? GetAllPosts(string baseUrl)
        {
            var request = new RestRequest($"/posts", Method.Get);

            var response = client.Execute(request);

            var posts = response.Content != null ? JsonConvert.DeserializeObject<PostResponse>(response.Content) : null;

            return posts?.Posts;
        }
    }   
}
