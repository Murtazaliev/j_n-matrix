using JournalNOEP_DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VURO.UI.Models
{
    public class DataConferenceViewModel
    {
        public IEnumerable<DataConferenceYear> DataConferenceYearList { get; set; }
        public IEnumerable<DataConferenceEdition> DataConferenceEditionList { get; set; }
    }
}
