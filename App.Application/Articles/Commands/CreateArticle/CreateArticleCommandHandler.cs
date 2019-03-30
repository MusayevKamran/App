using App.Domain.Entities;
using App.Persistance.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Articles.Commands.CreateArticle
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, int>
    {
        private readonly AppDbContext _context;
        public CreateArticleCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var entity = new Article
            {
                URL = request.URL,
                Title = request.Title,
                Row = request.Row
            };
            _context.Articles.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.ArticleId;
        }
    }
}
