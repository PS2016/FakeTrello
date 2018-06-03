using FT.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Mock
{
    public class DbFactory
    {
        private readonly FTContext _dbContext;
        private readonly Dictionary<System.Type, Action<object>> _defaults = new Dictionary<System.Type, Action<object>>();

        public DbFactory(FTContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Define<TModel>(Action<TModel> overrides) where TModel : class, new()
        {
            _defaults[typeof(TModel)] = obj => overrides(obj as TModel);
        }

        public TModel Create<TModel>(Action<TModel> overrides = null) where TModel : class, new()
        {
            var entity = new TModel();
            try
            {
                if (_defaults.TryGetValue(typeof(TModel), out Action<object> action))
                    action.Invoke(entity);

                overrides?.Invoke(entity);
                _dbContext.Entry(entity).State = EntityState.Added;
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return entity;
        }


    }
}

