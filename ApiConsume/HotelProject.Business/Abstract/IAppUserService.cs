using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace HotelProject.Business.Abstract
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        List<AppUser> TUserListWithWorkLocation();
    }
}
