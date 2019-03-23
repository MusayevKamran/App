using MediatR;

namespace App.Application.Article.Queries.GetArticle
{
    public class GetArticleQuery : IRequest<ArticleViewModel>
    {
        public int Id { get; set; }
    }
}
