using App.Application.Exceptions;
using App.Persistance.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Article.Commands.UpdateArticle
{
    public class UpdateArticleCommandHandler : IRequestHandler<UpdateArticleCommand, Unit>
    {
        private readonly AppDbContext _context;

        public UpdateArticleCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Articles.FindAsync(request.ArticleId);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Domain.Entities.Article), request.ArticleId);
            }

            entity.ArticleId = request.ArticleId;
            entity.Title = request.Title;
            entity.URL = request.URL;
            entity.Row = request.Row;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
