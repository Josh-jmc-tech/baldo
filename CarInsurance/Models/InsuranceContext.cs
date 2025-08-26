using System.Collections.Generic;
using System.Data.Entity;

namespace CarInsurance.Models
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext() : base("InsuranceDbContext") { }

        public DbSet<Insuree> Insurees { get; set; }
    }
}