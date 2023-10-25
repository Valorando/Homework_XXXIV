using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using TableModel;


namespace TableContext
{
    public class StandingsContext : DbContext
    {
        public StandingsContext()
        :base("DBConnection")
        { }

        public DbSet<Standings> Standings { get; set; }
    }
}