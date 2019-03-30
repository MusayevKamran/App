using App.Persistance.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Articles.Commands.DeleteArticle
{
    public class DeleteArticleCommand : IRequest
    {
        public int Id { get; set; }
    }
}
