using System;
using System.Collections.Generic;


namespace JournalNOEP_DOMAIN
{
    public partial class DataConferenceEdition
    {
        public DataConferenceEdition()
        {
            DataConferenceArticles = new HashSet<DataConferenceArticle>();
        }

        public Guid Id { get; set; }
        public string Edition { get; set; }
        public Guid DataConferenceYearId { get; set; }
        public string EdFile { get; set; }
        public string EdFileExt { get; set; }
        public int? AdditionalEdition { get; set; }

        public virtual DataConferenceYear DataConferenceYear { get; set; }
        public virtual ICollection<DataConferenceArticle> DataConferenceArticles { get; set; }
    }
}
