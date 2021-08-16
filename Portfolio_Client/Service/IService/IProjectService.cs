using System.Collections.Generic;
using System.Threading.Tasks;
using Portfolio_Client.Models;

namespace Portfolio_Client.Service.IService
{
    public interface IProjectService
    {
        public Task<IEnumerable<ProjectDTO>> GetAllProjects();
        public Task<ProjectDTO> GetProject(int projectId);
    }
}