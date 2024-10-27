using System;
using System.Collections.Generic;



namespace JournalNOEP_DOMAIN
{
    public partial class DataConferenceArticle
    {
        public Guid Id { get; set; }
        public string ArtUdk { get; set; }
        public string ArtName { get; set; }
        public string ArtAnnotation { get; set; }
        public string ArtKeywords { get; set; }
        public string ArtNameEng { get; set; }
        public string ArtAnnotationEng { get; set; }
        public string ArtKeywordsEng { get; set; }
        public string ArtFile { get; set; }
        public Guid? DataConferenceEditionId { get; set; }
        public int? ArtPos { get; set; }
        public string ArtFileXml { get; set; }

        public virtual DataConferenceEdition DataConferenceEdition { get; set; }
        public virtual ICollection<DataConferenceArticleAuthor> DataConferenceArticleAuthors { get; set; }
    }
}
