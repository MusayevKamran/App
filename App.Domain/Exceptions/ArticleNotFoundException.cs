using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Exceptions
{
    public class ArticleNotFoundException : Exception
    {
        public ArticleNotFoundException(int basketId) : base($"No basket found with id {basketId}")
        {
        }

        protected ArticleNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public ArticleNotFoundException(string message) : base(message)
        {
        }

        public ArticleNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
