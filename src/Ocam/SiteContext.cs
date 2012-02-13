﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ocam
{
    public class SiteConfiguration
    {
        public string IndexName { get; set; }
        public string PageStart { get; set; }
        public string Extension { get; set; }
        public string Permalink { get; set; }
        public string CategoryDir { get; set; }
        public string TagDir { get; set; }
        public bool Local { get; set; }
        public bool Rebase { get; set; }
    }
}