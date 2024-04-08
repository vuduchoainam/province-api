using provience_api.Models;

namespace provience_api.Services
{
    public interface IWardService
    {
        List<Ward> GetAll();
        List<Ward> GetByDistrictCode(string districtCode);


    }
}
