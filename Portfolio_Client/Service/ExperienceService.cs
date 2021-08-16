using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Portfolio_Client.Models;
using Portfolio_Client.Service.IService;

namespace Portfolio_Client.Service
{
    public class ExperienceService : IExperienceService
    {
        private readonly HttpClient _client;

        public ExperienceService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<ExperienceDTO>> GetAllExperiences()
        {
            // var response = await _client.GetAsync($"api/experience");
            // var content = await response.Content.ReadAsStringAsync();
            // var experiences = JsonConvert.DeserializeObject<IEnumerable<ExperienceDTO>>(content);
            var experiences =await _client.GetFromJsonAsync<ExperienceDTO[]>("api/experience");

            return experiences;
        }

        public Task<ExperienceDTO> GetExperience(int experienceId)
        {
            throw new NotImplementedException();
        }
    }
}