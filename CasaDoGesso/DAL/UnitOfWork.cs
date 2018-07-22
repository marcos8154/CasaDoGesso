using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UnitOfWork
    {
        public CasaDoGessoEntities Context { get; set; }

        public UnitOfWork(bool configureContextForPerformance = false)
        {
            Context = new CasaDoGessoEntities();

            if(configureContextForPerformance)
            {
                Context.Configuration.AutoDetectChangesEnabled = false;
                Context.Configuration.EnsureTransactionsForFunctionsAndCommands = false;
                Context.Configuration.LazyLoadingEnabled = false;
                Context.Configuration.ProxyCreationEnabled = false;
                Context.Configuration.UseDatabaseNullSemantics = false;
                Context.Configuration.ValidateOnSaveEnabled = false;
            }
        }

        public void BeginTransaction(System.Data.IsolationLevel? isoLevel = null)
        {
            if (isoLevel == null)
                Context.Database.BeginTransaction();
            else
                Context.Database.BeginTransaction((System.Data.IsolationLevel)isoLevel);
        }

        public void RollBack()
        {
            Context.Database.CurrentTransaction.Rollback();
        }

        public void Commit()
        {
            Context.Database.CurrentTransaction.Commit();
            Context.SaveChanges();
        }
    }
}
