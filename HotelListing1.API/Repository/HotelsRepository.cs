using HotelListing1.API.Contracts;
using HotelListing1.API.Data;

namespace HotelListing1.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
