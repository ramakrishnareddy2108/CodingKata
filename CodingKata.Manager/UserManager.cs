using Codingkata.Models;
using CodingKata.Manager.Abstractions;
using CodingKata.Repository.Abstractions;

namespace CodingKata.Manager
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        { 
            _userRepository = userRepository;
        }
        public async Task<bool> RegisterVaccination(VaccineRegister vaccineRegister)
        {
            //Validate Model
            return await _userRepository.RegisterVaccination(vaccineRegister);
        }
    }
}