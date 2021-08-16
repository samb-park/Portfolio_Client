using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Models;
using Portfolio_Client.Service.IService;

namespace Portfolio_Client.Service
{
    public class AboutMeService:IAboutMeService
    {
        private readonly HttpClient _client;

        public AboutMeService(HttpClient client)
        {
            _client = client;
        }

        public async Task<AboutMeDTO> GetAboutMe()
        {
            // var response = await _client.GetAsync($"api/aboutme");
            // var content = await response.Content.ReadAsStringAsync();
            // var abougMe = JsonConvert.DeserializeObject<AboutMeDTO>(content);
            // return abougMe;
            var result =await _client.GetFromJsonAsync<AboutMeDTO>("api/aboutme");
            return result;
        }
    }
}