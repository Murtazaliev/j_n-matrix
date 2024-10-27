using JournalNOEP_DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VURO.UI.Models
{
    public class MainViewModel
    {
        public IEnumerable<DataInfo> DataInfoList { get; set; }
        public DataInfo DataInfo { get; set; }
        public IEnumerable<SprJoiurnalAuthors> SprJoiurnalAuthorsList { get; set; }
        public IEnumerable<SprJournalSection> SprJournalSectionList { get; set; }
        public IEnumerable<DataYear> DataYearList { get; set; }
        public IEnumerable<DataEdition> DataEditionList { get; set; }
        public Articles Article { get; set; }
        public IEnumerable<Articles> ArticleList { get; set; }
        public IEnumerable<DataArticleAuthors> DataArticleAuthorsList { get; set; }
        public SprJoiurnalAuthors SprJoiurnalAuthor { get; set; }
        public IEnumerable<DataConferenceYear> DataConferenceYear { get; set; }
        public IEnumerable<DataConferenceEdition> DataConferenceEdition { get; set; }
        public DataConferenceArticle DataConferenceArticle { get; set; }
        public IEnumerable<DataConferenceArticleAuthor> DataConferenceArticleAuthor { get; set; }

        public static string Language = "RU";
    }
}
