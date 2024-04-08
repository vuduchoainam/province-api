using provience_api.Data;
using provience_api.Models;

namespace provience_api.Services
{
    public class ProvinceService : IProvinceService
    {
        private readonly ApplicationDbContext _context;

        public ProvinceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Province> GetAll()
        {
            return _context.Provinces.ToList();
        }
    }
}
