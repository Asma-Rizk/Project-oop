using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_oop
{
    class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationalID { get; set; }
        public string DateOfBirth { get; set; }

        public Customer(int id, string fullName, string nationalID, string dateOfBirth)
        {
            Id = id;
            FullName = fullName;
            NationalID = nationalID;
            DateOfBirth = dateOfBirth;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Customer ID: {Id}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"National ID: {NationalID}");
            Console.WriteLine($"Date of Birth: {DateOfBirth}");
        }

    }
}
