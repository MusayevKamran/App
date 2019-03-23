using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Article.Commands.CreateArticle
{
    public class CreateArticleCommand : IRequest<int>
    {
        public string Title { get; protected set; }

        public string URL { get; protected set; }

        public int Row { get; protected set; }
    }
}
