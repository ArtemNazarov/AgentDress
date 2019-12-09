using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgentDressReborn.Model
{
    public partial class Color
    {
        public int Id { get; set; }

        public string sColor { get; set; }

        public string Opacity { get; set; }

        public int SortOrder { get; set; }
        public bool Active { get; set; }
    }
}
