using System.Threading.Tasks;
using Models;


namespace Portfolio_Client.Service.IService
{
    public interface IAboutMeService
    {
        public Task<AboutMeDTO> GetAboutMe();
    }
}