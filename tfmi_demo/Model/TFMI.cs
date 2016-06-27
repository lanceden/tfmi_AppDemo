namespace tfmi_demo.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TFMI : DbContext
    {
        public TFMI()
            : base("name=TFMI")
        {
        }

        public virtual DbSet<Charity> Charity { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<TFMIServices> TFMIServices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
