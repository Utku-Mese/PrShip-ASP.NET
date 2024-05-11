using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrShip
{
    public class GitHubApiClient
    {
        private readonly HttpClient _httpClient;

        public GitHubApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserProfile> GetUserProfileAsync(string username)
        {
            var response = await _httpClient.GetAsync($"https://api.github.com/users/{username}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var userProfile = JsonConvert.DeserializeObject<UserProfile>(json);
                return userProfile;
            }
            return null;
        }

        public async Task<List<Project>> GetUserProjectsAsync(string username)
        {
            var response = await _httpClient.GetAsync($"https://api.github.com/users/{username}/repos");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var projects = JsonConvert.DeserializeObject<List<Project>>(json);
                return projects;
            }
            return null;
        }
    }

    public class UserProfile
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        //TODO: Diğer bilgiler
    }

    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //TODO: Diğer bilgiler
    }
}
