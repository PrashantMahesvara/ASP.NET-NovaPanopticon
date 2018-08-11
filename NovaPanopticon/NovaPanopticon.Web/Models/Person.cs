using System;
using System.ComponentModel.DataAnnotations;

namespace NovaPanopticon.Web.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SocialSecurityNumber { get; set; }

        public string StreetAddress { get; set; }
        public string StreetNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Municipal { get; set; }

        public string Email { get; set; }
        public int PhoneNumber { get; set; }

    }
}