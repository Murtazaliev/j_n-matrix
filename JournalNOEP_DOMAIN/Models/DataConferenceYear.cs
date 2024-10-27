using System;
using System.Collections.Generic;


namespace JournalNOEP_DOMAIN
{
    public partial class DataConferenceYear
    {
        public DataConferenceYear()
        {
            DataConferenceEditions = new HashSet<DataConferenceEdition>();
        }

        public Guid Id { get; set; }
        public int Year { get; set; }

        public virtual ICollection<DataConferenceEdition> DataConferenceEditions { get; set; }
    }
}
