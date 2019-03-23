using App.Persistance.Data;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Article.Queries.GetAllArticles
{
    public class GetAllArticlesQueryHandler : IRequestHandler<GetAllArtilesQuery, ArticlesListViewModel>
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public GetAllArticlesQueryHandler(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ArticlesListViewModel> Handle(GetAllArtilesQuery request, CancellationToken cancellationToken)
        {
            var articles = await _context.Articles.OrderBy(p => p.ArticleId).ToListAsync(cancellationToken);

            var model = new ArticlesListViewModel
            {
                Articles = _mapper.Map<IEnumerable<ArticleDto>>(articles),
                CreateEnabled = true
            };
            return model;
        }
    }
}