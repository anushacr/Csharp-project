using CityBusManagment.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagment.DAL.Repository
{
    public interface IAdminInfoRepository
    {
        AdminInfo Login(AdminInfo user);
    }
}

