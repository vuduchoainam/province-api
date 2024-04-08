using provience_api.Models;

namespace provience_api.Services
{
    public interface IDistrictService
    {
        List<District> GetAll();
        List<District> GetByProvinceCode(string provinceCode);
    }
}
