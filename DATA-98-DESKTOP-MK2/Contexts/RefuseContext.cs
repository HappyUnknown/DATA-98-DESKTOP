using DATA_98_DESKTOP_MK2.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_98_DESKTOP_MK2.Contexts
{
    class RefuseContext : DbContext
    {
        public DbSet<Refuse> Refuses { get; set; }
        public RefuseContext() : base("Data98Connection")
        {

        }
    }
}
