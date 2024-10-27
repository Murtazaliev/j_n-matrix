using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JournalNOEP_DOMAIN
{
    public partial class Articles
    {
        public Articles()
        {
            DataArticleAuthors = new HashSet<DataArticleAuthors>();
        }

        public Guid Id { get; set; }
        public Guid SectionId { get; set; }
        public string ArtUdk { get; set; }
        public string ArtName { get; set; }        
        public string ArtAnnotation { get; set; }
        public string ArtKeywords { get; set; }
        public string ArtNameEng { get; set; }        
        public string ArtAnnotationEng { get; set; }
        public string ArtKeywordsEng { get; set; }
        public string ArtFile { get; set; }
        public Guid EditionId { get; set; }
        public int? ArtPos { get; set; }

        public virtual DataEdition Edition { get; set; }
        public virtual SprJournalSection Section { get; set; }
        public virtual ICollection<DataArticleAuthors> DataArticleAuthors { get; set; }
    }
}
