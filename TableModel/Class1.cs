using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TableModel
{
    public class Standings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Place { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Draw { get; set; }
    }
}