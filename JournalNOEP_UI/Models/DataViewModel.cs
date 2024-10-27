using JournalNOEP_DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JournalNOEP_UI.Models
{
    public class DataViewModel
    {
        public IEnumerable<DataYear> DataYearList { get; set; }
        public IEnumerable<DataEdition> DataEditionList { get; set; }
    }
}
