using Codingkata.Models;
using CodingKata.Repository.Abstractions;

namespace CodingKata.Repository
{
    public class UserRepository : IUserRepository
    {
        List<VaccineRegister> registrations = new List<VaccineRegister>();
        public async Task<bool> RegisterVaccination(VaccineRegister vaccineRegister)
        {
            //Data base operation
            registrations.Add(vaccineRegister);
            return true;
        }
    }
}