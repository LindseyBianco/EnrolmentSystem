using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class Person
    {
        // constants
        public const string DEFAULT_NAME = "No name provided.";
        public const string DEFAULT_EMAIL = "No email provided.";
        public const string DEFAULT_PHONE_NUMBER = "No phoneNumber provided.";

        // variables
        private string name;
        private string email;
        private string phoneNumber;

        // get set properties
        public string Name { get { return name; } set { name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public Address Address { get; set; }

        // no arg
        public Person() : this(DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE_NUMBER, new Address())
        {
        }

        // all arg
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // ToString
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("    - Person:");
            stringBuilder.AppendLine($"       - Name: { Name}");
            stringBuilder.AppendLine($"       - Email: {Email}");
            stringBuilder.AppendLine($"       - Phone Number: {PhoneNumber}");
            stringBuilder.AppendLine($"{Address}");
            return stringBuilder.ToString();
        }
    }
}