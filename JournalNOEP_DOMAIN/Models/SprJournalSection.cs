using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JournalNOEP_DOMAIN
{
    public partial class SprJournalSection
    {
        public SprJournalSection()
        {
            Articles = new HashSet<Articles>();
        }

        public Guid Id { get; set; }
        public string SectionName { get; set; }
        [MaxLength(10000)]
        public string SectionInfo { get; set; }
        public string SectionNameEng { get; set; }
        [MaxLength(10000)]
        public string SectionInfoEng { get; set; }

        public int SectionPos { get; set; }

        public virtual ICollection<Articles> Articles { get; set; }
    }
}
