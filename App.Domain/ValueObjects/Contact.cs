using App.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.ValueObjects
{
    public class Contact : ValueObject
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
