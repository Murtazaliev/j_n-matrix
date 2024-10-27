using System;
using System.Collections.Generic;

namespace JournalNOEP_DOMAIN
{
    public partial class DataEdition
    {

            public DataEdition()
            {
                Articles = new HashSet<Articles>();
            }

            public Guid Id { get; set; }
            public int Edition { get; set; }
            public Guid IdYear { get; set; }
            public string EdFile { get; set; }
            public string EdFileExt { get; set; }

            public virtual DataYear IdYearNavigation { get; set; }
            public virtual ICollection<Articles> Articles { get; set; }

    }
}
