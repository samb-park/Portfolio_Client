using System.Threading.Tasks;
using AboutMeDTO = Portfolio_Client.Models.AboutMeDTO;
using Portfolio_Client.Models;


namespace Portfolio_Client.Service.IService
{
    public interface IAboutMeService
    {
        public Task<AboutMeDTO> GetAboutMe();
    }
}