using JournalNOEP_DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JournalNOEP_UI.Models
{
    public class ArticleViewModel
    {
        public IEnumerable<SprJoiurnalAuthors> SprJoiurnalAuthorsList { get; set; }
        public Articles Article { get; set; }
    }
}
