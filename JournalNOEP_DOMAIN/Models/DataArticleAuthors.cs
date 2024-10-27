using System;
using System.Collections.Generic;

namespace JournalNOEP_DOMAIN
{
    public partial class DataArticleAuthors
    {
        public Guid ArticleId { get; set; }
        public Guid AuthorId { get; set; }
        public Guid Id { get; set; }
        public int AuthorPos { get; set; }

        public virtual Articles Article { get; set; }
        public virtual SprJoiurnalAuthors Author { get; set; }
    }
}
