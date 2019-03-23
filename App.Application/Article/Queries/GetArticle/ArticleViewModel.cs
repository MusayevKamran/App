using App.Application.Interfaces.Mapping;
using AutoMapper;
using App.Domain.Entities;

namespace App.Application.Article.Queries.GetArticle
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
            configuration.CreateMap<Domain.Entities.Article, ArticleViewModel>()
               .ForMember(pDTO => pDTO.EditEnabled, opt => opt.MapFrom<PermissionsResolver>())
               .ForMember(pDTO => pDTO.DeleteEnabled, opt => opt.MapFrom<PermissionsResolver>())
               .ForMember(pDTO => pDTO.Title, opt => opt.MapFrom(p => p.Title != null ? p.Title : string.Empty));

        }
        class PermissionsResolver : IValueResolver<Domain.Entities.Article, ArticleViewModel, bool>
        {
            // TODO: inject your services and helper here
            public PermissionsResolver()
            {

            }

            public bool Resolve(Domain.Entities.Article source, ArticleViewModel dest, bool destMember, ResolutionContext context)
            {
                return false;
            }
        }
    }
}
