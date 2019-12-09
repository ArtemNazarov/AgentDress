using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgentDressReborn.Model
{
    public partial class Store
    {

        public Store()
        {
            Dresses = new HashSet<Dress>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public int PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string WebSite { get; set; }

        public string Email { get; set; }

        public string Fax { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dress> Dresses{ get; set; }
    }
}
