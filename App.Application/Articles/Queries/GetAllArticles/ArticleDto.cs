using App.Application.Interfaces.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Articles.Queries.GetAllArticles
{
    public class ArticleDto : IHaveCustomMapping
    {
        public int ArticleId { get;  set; }

        public string Title { get;  set; }

        public string URL { get;  set; }

        public int Row { get;  set; }

        public void CreateMappings(Profile configuration)
        {
            //configuration.CreateMap<Domain.Entities.Article, ArticleDto>()
            //    .ForMember(pDTO => pDTO.Title, opt => opt.MapFrom(p => p.Title != null ? p.Title : string.Empty));
        }
    }
}
