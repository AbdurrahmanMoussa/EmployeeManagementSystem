using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Address
    {
      /*  public Address(string city, string country, string postalCode, string state,string street )
        {
            City = city;
            Country = country;
            PostalCode = postalCode;
            State = state;
            Street = street;
        }*/

        [Key]
        public int AddressId { get; set; }
        [Required]
        public string City { get; set; } 
        [Required]
        public string Country { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Street { get; set; }


    }

}