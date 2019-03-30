using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Articles.Queries.GetAllArticles
{
    public class GetAllArtilesQuery :IRequest<ArticlesListViewModel>
    {
    }
}
