using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Portfolio_Client.Service.IService
{
    public interface IExperienceService
    {
        public Task<IEnumerable<ExperienceDTO>> GetAllExperiences();
        public Task<ExperienceDTO> GetExperience(int experienceId);
    }
}