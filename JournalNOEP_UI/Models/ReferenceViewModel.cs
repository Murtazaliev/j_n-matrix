using JournalNOEP_DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JournalNOEP_UI.Models
{
    public class ReferenceViewModel
    {
        public IEnumerable<SprJoiurnalAuthors> SprJoiurnalAuthorsList { get; set; }
        public IEnumerable<SprJournalSection> SprJournalSectionList { get; set; }
    }
}
