﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer.DAL.Entities
{
    public class AppliedRule: EntryBaseModel
    {
        public int RuleId { get; set; }
        public virtual Rule Rule { get; set; }

        public int AppliedRuleBlockId { get; set; }
        public virtual AppliedRuleBlock AppliedRuleBlock { get; set; }

        public int Index { get; set; }

        public virtual ICollection<AppliedRuleResult> AppliedRuleResults { get; set; } = new Collection<AppliedRuleResult>();
        
    }
}
