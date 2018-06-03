using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Services.Base
{
    public class ServiceBase<TModel> where Tcontext:DbContext
    {
        protected readonly Tcontext _context;

        public ServiceBase(Tcontext context)
        {
            _context = context;
        }
    }
}
