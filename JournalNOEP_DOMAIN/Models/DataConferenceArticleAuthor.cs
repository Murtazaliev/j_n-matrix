using System;
using System.Collections.Generic;


namespace JournalNOEP_DOMAIN
{
    public partial class DataConferenceArticleAuthor
    {
        public Guid Id { get; set; }
        public Guid? DataConferenceArticleId { get; set; }
        public Guid? SprJoiurnalAuthorsId { get; set; }
        public int? AuthorPos { get; set; }

        public virtual DataConferenceArticle DataConferenceArticle { get; set; }
        public virtual SprJoiurnalAuthors SprJoiurnalAuthors { get; set; }
    }
}
