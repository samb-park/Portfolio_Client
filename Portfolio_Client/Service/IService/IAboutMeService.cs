using System.Threading.Tasks;
using Models;
using AboutMeDTO = Portfolio_Client.Models.AboutMeDTO;


namespace Portfolio_Client.Service.IService
{
    public interface IAboutMeService
    {
        public Task<AboutMeDTO> GetAboutMe();
    }
}