namespace ProjectTeam06TermProject.EF_Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ECommerceEntities : DbContext
    {
        public ECommerceEntities()
            : base("name=ECommerceConnection")
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Posting> Postings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.ItemPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.ItemNum);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Postings)
                .WithRequired(e => e.Item)
                .HasForeignKey(e => e.ItemNum);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Participant>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Participant)
                .HasForeignKey(e => e.BuyerNum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Participant>()
                .HasMany(e => e.Postings)
                .WithRequired(e => e.Participant)
                .HasForeignKey(e => e.SellerNum)
                .WillCascadeOnDelete(false);
        }
    }
}
