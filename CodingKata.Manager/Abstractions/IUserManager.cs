using Codingkata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata.Manager.Abstractions
{
    public interface IUserManager
    {
        Task<bool> RegisterVaccination(VaccineRegister vaccineRegister); 
    }
}
