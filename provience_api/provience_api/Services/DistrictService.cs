using provience_api.Data;
using provience_api.Models;
using System.Collections.Generic;
using System.Linq;

namespace provience_api.Services
{
    public class DistrictService : IDistrictService
    {
        private readonly ApplicationDbContext _context;

        public DistrictService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<District> GetAll()
        {
            return _context.Districts.ToList();
        }

        public List<District> GetByProvinceCode(string provinceCode)
        {
            return _context.Districts.Where(d => d.ProvinceCode == provinceCode).ToList();
        }

    }
}
