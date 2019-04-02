using App.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.ValueObjects
{
    public class Contact : ValueObject
    {
        public String Street { get; private set; }
        public String Email { get; private set; }
        public String PhoneNumber { get; private set; }

        private Contact() { }

        public Contact(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;

        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            // Using a yield return statement to return each element one at a time
            yield return Email;
            yield return PhoneNumber;
        }
    }
}
