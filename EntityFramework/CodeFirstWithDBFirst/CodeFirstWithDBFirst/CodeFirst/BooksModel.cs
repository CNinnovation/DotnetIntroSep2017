namespace CodeFirstWithDBFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BooksModel : DbContext
    {
        public BooksModel()
            : base("name=BooksModel")
        {
        }

        public virtual DbSet<MyBook> MyBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
