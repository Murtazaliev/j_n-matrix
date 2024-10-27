using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JournalNOEP_DOMAIN
{
    public partial class DataInfo
    {
        public Guid Id { get; set; }
        public string InfoNameRu { get; set; }
        public string InfoNameEn { get; set; }
        [MaxLength(10000)]
        public string InfoTextRu { get; set; }
        [MaxLength(10000)]
        public string InfoTextEn { get; set; }
        public int? InfoPageNum { get; set; }
        public bool IsSectionOnMainPage { get; set; }
    }
}
