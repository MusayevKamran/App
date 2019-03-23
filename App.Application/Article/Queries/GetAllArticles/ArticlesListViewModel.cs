﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Article.Queries.GetAllArticles
{
    public class ArticlesListViewModel
    {
        public IEnumerable<ArticleDto> Articles { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
