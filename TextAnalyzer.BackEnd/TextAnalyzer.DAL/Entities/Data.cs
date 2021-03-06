﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer.DAL.Entities
{
    public class Data: EntryBaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DataValue { get; set; }

        public virtual ICollection<AppliedRuleBlock> AppliedRuleBlocks { get; set; } = new Collection<AppliedRuleBlock>();
    }
}
