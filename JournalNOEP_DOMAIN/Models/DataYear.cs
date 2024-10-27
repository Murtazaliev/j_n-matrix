using System;
using System.Collections.Generic;

namespace JournalNOEP_DOMAIN
{
    public partial class DataYear
    {
        public DataYear()
        {
            DataEdition = new HashSet<DataEdition>();
        }

        public Guid Id { get; set; }
        public int Year { get; set; }

        public virtual ICollection<DataEdition> DataEdition { get; set; }
    }
}
