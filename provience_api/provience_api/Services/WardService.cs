using provience_api.Data;
using provience_api.Models;

namespace provience_api.Services
{
    public class WardService : IWardService
    {
        private readonly ApplicationDbContext _context;

        public WardService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Ward> GetAll()
        {
            return _context.Wards.ToList();
        }

        public List<Ward> GetByDistrictCode(string districtCode)
        {
            return _context.Wards.Where(d => d.DistrictCode == districtCode).ToList();
        }
    }
}
