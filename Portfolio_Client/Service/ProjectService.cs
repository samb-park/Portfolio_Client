using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Portfolio_Client.Models;
using Portfolio_Client.Service.IService;

namespace Portfolio_Client.Service
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _client;

        public ProjectService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<ProjectDTO>> GetAllProjects()
        {
            // var response = await _client.GetAsync($"api/project");
            // var content = await response.Content.ReadAsStringAsync();
            // var projects = JsonConvert.DeserializeObject<IEnumerable<ProjectDTO>>(content);
            var projects =await _client.GetFromJsonAsync<ProjectDTO[]>("api/project");
            return projects;
        }

        public Task<ProjectDTO> GetProject(int projectId)
        {
            throw new System.NotImplementedException();
        }
    }
}