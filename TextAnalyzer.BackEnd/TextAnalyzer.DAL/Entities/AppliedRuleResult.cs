﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer.DAL.Entities
{
    public class AppliedRuleResult: EntryBaseModel
    {
        public int AppliedRuleId { get; set; }
        public virtual AppliedRule AppliedRule { get; set; }

        public int? IndexInText { get; set; }
        public string Value { get; set; }
    }
}
