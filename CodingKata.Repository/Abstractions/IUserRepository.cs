using Codingkata.Models;

namespace CodingKata.Repository.Abstractions
{
    public interface IUserRepository
    {
        Task<bool> RegisterVaccination(VaccineRegister vaccineRegister);
    }

}
