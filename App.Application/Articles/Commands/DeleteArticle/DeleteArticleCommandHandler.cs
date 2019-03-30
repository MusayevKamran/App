using App.Application.Exceptions;
using App.Domain.Entities;
using App.Persistance.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Articles.Commands.DeleteArticle
{
    public class DeleteArticleCommandHandler : IRequestHandler<DeleteArticleCommand>
    {
        private readonly AppDbContext _context;
        public DeleteArticleCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteArticleCommand request, CancellationToken cancellationToken)
        {
            Article entity = await _context.Articles.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Article), request.Id);
            }

            _context.Articles.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
