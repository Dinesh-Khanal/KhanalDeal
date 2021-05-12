using KhanalDeal.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanalDeal.Data
{
    class KhanalDealContext : DbContext
    {
        public KhanalDealContext() : base("KhanalDealConnection")
        {
        }

        public DbSet<Aution> Auctions { get; set; }
    }
}
