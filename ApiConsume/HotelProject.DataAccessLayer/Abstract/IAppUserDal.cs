﻿using HotelProject.EntityLayer.Concrete;
using System.Collections.Generic;
namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
    }
}