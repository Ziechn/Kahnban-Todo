using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    internal class Contact
    {
        public string Email { get; set; } = "";
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string PrimaryContactMethod { get; set; } = "";
        public string PrimaryContact { get; set; } = "";

        public Contact(string email, long id, string name, string phoneNumber, string primaryContactMethod, string primaryContact)
        {
            Email = email;
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            PrimaryContactMethod = primaryContactMethod;
            PrimaryContact = primaryContact;
        }
    }
}
