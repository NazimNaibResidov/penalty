namespace Paractika.Win.UI.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Main : DbContext
    {
       
        public Main()
            : base("name=Main")
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Identity> Identities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<Fire> Fires { get; set; }
    }

   
}