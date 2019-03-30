using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using App.Persistance.Data;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace App.Application.Articles.Queries.GetArticle
{
    public class GetArticleQueryHandler : IRequestHandler<GetArticleQuery, ArticleViewModel>
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public GetArticleQueryHandler(AppDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ArticleViewModel> Handle(GetArticleQuery request, CancellationToken cancellationToken)
        {
            var article = _mapper.Map<ArticleViewModel>(await _context
                .Articles.Where(a => a.ArticleId == request.Id)
                .SingleOrDefaultAsync(cancellationToken));

            article.EditEnabled = true;
            article.DeleteEnabled = false;

            return article;
        }
    }
}
