using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Commits
{
    public class Commit
    {
        public string CommitHash { get; set; }

        public string Message { get; set; }

        public decimal Additions { get; set; }

        public decimal Deletions { get; set; }
    }
}
