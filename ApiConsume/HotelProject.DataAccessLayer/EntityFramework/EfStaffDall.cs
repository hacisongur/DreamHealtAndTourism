using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrate;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfStaffDall:GenericRepository<Staff> ,IStaffDal
    {
        public EfStaffDall(Context context):base(context)
        {

        }
    }
}
