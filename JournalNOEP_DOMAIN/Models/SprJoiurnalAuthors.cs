using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JournalNOEP_DOMAIN
{
    public partial class SprJoiurnalAuthors
    {
        public SprJoiurnalAuthors()
        {
            DataArticleAuthors = new HashSet<DataArticleAuthors>();
        }

        public Guid Id { get; set; }
        public string AuthFio { get; set; }
        [MaxLength(10000)]
        public string AuthRegal { get; set; }
        public string AuthFioEng { get; set; }
        [MaxLength(10000)]
        public string AuthRegalEng { get; set; }
        public string AuthJobMail { get; set; }
        public string AuthJobMailEng { get; set; }

        public virtual ICollection<DataArticleAuthors> DataArticleAuthors { get; set; }
        public virtual ICollection<DataConferenceArticleAuthor> DataConferenceArticleAuthors { get; set; }
    }
}
