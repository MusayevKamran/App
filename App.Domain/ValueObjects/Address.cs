using System;
using System.Collections.Generic;
using App.Domain.Infrastructure;

namespace App.Domain.ValueObjects
{
    public class Address : ValueObject // ValueObject
    {
        public String Street { get; private set; }

        public String City { get; private set; }

        public String State { get; private set; }

        public String Country { get; private set; }

        public String ZipCode { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
