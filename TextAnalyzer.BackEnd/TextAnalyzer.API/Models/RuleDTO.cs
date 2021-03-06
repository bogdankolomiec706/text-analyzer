﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextAnalyzer.API.Models
{
    public class RuleDTO: BaseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int? MinMatchesNumber { get; set; }
        public int? MaxMatchesNumber { get; set; }

    }
}