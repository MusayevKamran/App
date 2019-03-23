using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Article.Queries.GetAllArticles
{
    public class GetAllArtilesQuery :IRequest<ArticlesListViewModel>
    {
    }
}
