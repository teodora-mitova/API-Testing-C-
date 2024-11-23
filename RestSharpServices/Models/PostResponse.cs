using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestSharpServices.Models
{
    public class PostResponse
    {
        [JsonPropertyName("posts")]
        public List<Post>? Posts { get; set; }
       
    }
}
