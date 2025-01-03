using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber8
{
    public class PostManagement
    {
        readonly string _url = "https://jsonplaceholder.typicode.com/posts";
        public async Task<List<Post>> GetAllPosts()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("/posts");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("the Request is success");  
                var data = await response.Content.ReadAsStringAsync();
                var posts = JsonConvert.DeserializeObject<List<Post>>(data);

                return posts;
            }
            else
            {
                Console.WriteLine("the Request is failed");
            }

            return new List<Post>();
        } 

        public async Task CreatePost(int userId,string Title,string Body)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_url); 

            Post post = new Post
            {
                UserId = userId,
                Title = Title,
                Body = Body
            };
            
            string json = JsonConvert.SerializeObject(post);

            HttpResponseMessage httpResponseMessage = 
                await client.PostAsync("/posts", new StringContent(json, Encoding.UTF8, "application/json"));
        
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("the Request is success");
                var response = await httpResponseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(response);
            }

        }

        public async Task UpdatePost(int userId, string Title, string Body)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_url);

            Post post = new Post
            {
                UserId = userId,
                Title = Title,
                Body = Body,
                Id = 1
            };

            string json = JsonConvert.SerializeObject(post);

            HttpResponseMessage httpResponseMessage =
                await client.PutAsync("/posts/1", new StringContent(json, Encoding.UTF8, "application/json"));

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("the Request is success");
                var response = await httpResponseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(response);
            }

        }
        
        public async Task DeletePost(int postId)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_url);
            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync("/posts/1");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                Console.WriteLine("Request is success");
                var data = await httpResponseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            }
        }
    }
}
