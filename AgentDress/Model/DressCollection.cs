using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgentDressReborn.Model
{
    public partial class DressCollection
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dress> Dresses { get; set; }
    }
}
