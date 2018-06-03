using FT.Data;

namespace FT.Services
{
    public class ServiceBase
    {
        protected readonly FTContext _context;

        public ServiceBase(FTContext context)
        {
            _context = context;
        }
    }
}
