using System.ComponentModel.DataAnnotations;

namespace Codingkata.Models
{
    public class VaccineRegister
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }

        public string EmailId { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string IdentityNumber { get; set; }  //Can verify with multiple Identities like aadhar or voter id , now keeping it simple with adhar validation
        [Required]
        public int VaccineTypeId { get; set; }
        public int DoseNumber { get; set; }
        public DateTime VaccinationDate { get; set; }
        public int vaccinationCenterId { get; set; }
    }

    public enum Gender
    { 
        Male,
        Female,
        Others
    }

}

