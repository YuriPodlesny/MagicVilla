using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsunc<T>(LoginRequestDTO objToCreate);
        Task<T> RegisterAsunc<T>(RegistrationRequestDTO objToCreate);
    }
}
