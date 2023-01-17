using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;



namespace FormUI
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }


        public DbSet<ASXPriceModel> ASXPrices { get; set; }

        public DbSet<DocumentUploadHistoryModel> DocumentUploadHistories { get; set; }

        public DbSet<ShareTransactionsModel> ShareTransactions { get; set; }

        public DbSet<ShareTransactionTypeModel> ShareTranactionTypes { get; set; }


        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ASXPriceModel>().ToTable("ASXSharePrice");
            modelBuilder.Entity<DocumentUploadHistoryModel>().ToTable("DocumentUploadHistory");
            modelBuilder.Entity<ShareTransactionsModel>().ToTable("ShareTransaction");
            modelBuilder.Entity<ShareTransactionTypeModel>().ToTable("ShareTransactionType");
        }
        */


    }
}

