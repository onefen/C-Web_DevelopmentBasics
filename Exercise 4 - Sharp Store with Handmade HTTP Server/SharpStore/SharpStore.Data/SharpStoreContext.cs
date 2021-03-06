namespace SharpStore.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class SharpStoreContext : DbContext
    {
        public SharpStoreContext()
            : base("name=SharpStoreContext")
        {
        }

        public virtual DbSet<Knife> Knives { get; set; }

        public virtual DbSet<Message> Messages { get; set; }
    }
}