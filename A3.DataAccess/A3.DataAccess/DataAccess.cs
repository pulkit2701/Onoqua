using A3.Common;
using Onoqua.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;


namespace A3.DataAccess
{
    public class DataAccess<TObject> 

        where TObject : class
    {
        public OnoquaContext Context;
        private bool shareContext = false;

        public DataAccess()
        {
            Context = new OnoquaContext();
            Context.Configuration.ProxyCreationEnabled = false;
        }

        public DataAccess(OnoquaContext context)
        {
            Context = context;
            shareContext = true;
            Context.Configuration.ProxyCreationEnabled = false;
        }

        protected DbSet<TObject> DbSet
        {
            get
            {
                return Context.Set<TObject>();
            }
        }

        public void Dispose()
        {
            if (shareContext && (Context != null))
                Context.Dispose();
        }

        public virtual IQueryable<TObject> All()
        {
            return DbSet.AsQueryable();
        }


        public virtual List<TObject> Create(List<TObject> TObject)
        {
            var result = new List<TObject>();
            foreach (var i in TObject)
                result.Add(DbSet.Add(i));
            Context.SaveChanges();
            return result;

        }

        public virtual TObject Create(TObject TObject)
        {
            try
            {
                var newEntry = DbSet.Add(TObject);
                Context.SaveChanges();
                return newEntry;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public virtual int Count
        {
            get
            {
                return DbSet.Count();
            }
        }

        public virtual int Delete(TObject TObject)
        {
            DbSet.Remove(TObject);
            return Context.SaveChanges();
        }

        public virtual int Update(TObject TObject)
        {
            var entry = Context.Entry(TObject);
            DbSet.Attach(TObject);
            entry.State = EntityState.Modified;
            return Context.SaveChanges();
        }

        public virtual IQueryable<TObject> Where(Expression<Func<TObject,bool>> predicate)
        {
            try
            {
                return DbSet.Where(predicate);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }



        public virtual IQueryable<TObject> Include(Expression<Func<TObject, object>> predicate)
        {
            return DbSet.Include(predicate);
        }

        public virtual DbQuery<TObject> Include(string path)
        {
            return DbSet.Include(path);
        }

        public virtual int Save()
        {
            try
            {
                return Context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var i in e.EntityValidationErrors)
                    foreach (var a in i.ValidationErrors)
                        e.Data(a.PropertyName, a.ErrorMessage);
                throw new Exception(e.Message, e);
            }
        }

        public virtual DbEntityEntry Attach(TObject entity)
        {
            var e = Context.Entry(entity);
            DbSet.Attach(entity);
            return e;
        }

    }
}
