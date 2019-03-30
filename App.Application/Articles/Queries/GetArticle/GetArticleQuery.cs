using MediatR;

namespace App.Application.Articles.Queries.GetArticle
{
    public class GetArticleQuery : IRequest<ArticleViewModel>
    {
        public int Id { get; set; }
    }
}
