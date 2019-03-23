using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Article.Commands.UpdateArticle
{
    public class UpdateArticleCommand : IRequest
    {
        public int ArticleId { get; set; }

        public string Title { get; set; }

        public string URL { get; set; }

        public int Row { get; set; }
    }
}
