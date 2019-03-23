using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Application.Article.Commands.CreateArticle;
using App.Application.Article.Commands.DeleteArticle;
using App.Application.Article.Commands.UpdateArticle;
using App.Application.Article.Queries.GetAllArticles;
using App.Application.Article.Queries.GetArticle;
using MediatR;

namespace App.Admin.Controllers
{
    public class ArticlesController : BaseController
    {

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<ArticlesListViewModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllArtilesQuery()));
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArticleViewModel>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetArticleQuery { Id = id }));
        }

        // POST: api/products
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateArticleCommand command)
        {
            var productId = await Mediator.Send(command);

            return Ok(productId);
        }

        // PUT: api/products/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ArticleDto>> Update(
            [FromRoute] int id,
            [FromBody] UpdateArticleCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        // DELETE: api/products/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteArticleCommand { Id = id });

            return NoContent();
        }
    }
}