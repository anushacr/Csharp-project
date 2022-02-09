using CityBusManagment.DAL.Repository;
using CityBusManagment.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagment.BAL.Service
{
    public class AdminInfoService
    {
        private IAdminInfoRepository _adminInfoRepository;
        public AdminInfoService(IAdminInfoRepository adminInfoRepository)
        {
            _adminInfoRepository = adminInfoRepository;
        }

        public AdminInfo Login(AdminInfo userInfo)
        {
            throw new NotImplementedException();
        }
    }
}
