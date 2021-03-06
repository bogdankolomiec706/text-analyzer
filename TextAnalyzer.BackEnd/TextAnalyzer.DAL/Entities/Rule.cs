﻿using Algorithms.Models.ConstantsAndEnums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace TextAnalyzer.DAL.Entities
{
    public class Rule: EntryBaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int? MinMatchesNumber { get; set; }
        public int? MaxMatchesNumber { get; set; }

        public RulesConnectionType InnerConnectionType { get; set; }

        public virtual ICollection<RegularExpression> RegularExpressions { get; set; } = new Collection<RegularExpression>();
        public virtual ICollection<AppliedRule> AppliedRules { get; set; } = new Collection<AppliedRule>();
    }
}
