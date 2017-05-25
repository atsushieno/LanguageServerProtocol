﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageServer.Parameters
{
    public class SymbolInformation
    {
        public string name { get; set; }
        public SymbolKind kind { get; set; }
        public Location location { get; set; }
        public string containerName { get; set; }
    }
}
