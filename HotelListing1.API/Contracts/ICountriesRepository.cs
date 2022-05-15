using HotelListing1.API.Data;

namespace HotelListing1.API.Contracts
{
    public interface ICountriesRepository : IGenericRepository <Country>
    {
        Task<Country> GetDetails(int id);

    }
}
