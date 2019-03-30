using App.Application.Interfaces.Mapping;
using App.Domain.Entities;
using AutoMapper;

namespace App.Application.Articles.Queries.GetArticle
{
    public class ArticleViewModel : IHaveCustomMapping
    {
        public int ArticleId { get; protected set; }

        public string Title { get; protected set; }

        public string URL { get; protected set; }

        public int Row { get; protected set; }
        public bool EditEnabled { get; set; }
        public bool DeleteEnabled { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Article, ArticleViewModel>()
               .ForMember(pDTO => pDTO.EditEnabled, opt => opt.MapFrom<PermissionsResolver>())
               .ForMember(pDTO => pDTO.DeleteEnabled, opt => opt.MapFrom<PermissionsResolver>())
               .ForMember(pDTO => pDTO.Title, opt => opt.MapFrom(p => p.Title != null ? p.Title : string.Empty));

        }
        class PermissionsResolver : IValueResolver<Article, ArticleViewModel, bool>
        {
            // TODO: inject your services and helper here
            public PermissionsResolver()
            {

            }

            public bool Resolve(Article source, ArticleViewModel destination, bool destMember, ResolutionContext context)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
